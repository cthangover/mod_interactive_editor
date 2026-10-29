namespace Cthangover.Tools.Services
{
    using System;
    using System.Collections.Generic;

    /// <summary>Finds the scene that adds each interactive through scenario commands.</summary>
    public static class InteractiveSceneService
    {
        private const string InteractiveAddCommand = "interactive_add";

        /// <summary>
        /// Scans every scenario once and maps interactive IDs to the scene of
        /// the first scenario that adds them.
        /// </summary>
        public static Dictionary<string, string> MapInteractivesToScenes()
        {
            var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var mod in ScenarioFileService.ScanScenarioFiles())
            {
                foreach (var group in mod.Groups)
                {
                    foreach (var file in group.Files)
                    {
                        var text = ScenarioFileService.ReadAllText(file.ModId, file.RelativePath);
                        if (string.IsNullOrEmpty(text) || text.IndexOf(InteractiveAddCommand, StringComparison.Ordinal) < 0)
                            continue;

                        var scene = ScenarioFileService.ParseMetadata(text).Scene;
                        foreach (var raw in text.Split('\n'))
                        {
                            var tokens = ScenarioSyntaxService.Tokenize(raw.Trim());
                            if (tokens.Count >= 2 && tokens[0] == InteractiveAddCommand && !result.ContainsKey(tokens[1]))
                                result[tokens[1]] = scene;
                        }
                    }
                }
            }

            return result;
        }
    }
}
