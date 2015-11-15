﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace _2DV610.Classes
{
    public class Svg
    {
        List<PathCommand> pathCommands;

        public PathCommand[] PathCommands
        {
            get
            {
                return pathCommands.ToArray();
            }
        }

        public int CommandCount {
            get
            {
                return pathCommands.Count;
            }
        }
        public Svg(string path)
        {
            Initialize();
            string[] paths = SplitMultiCommandSvgPath(path);
            float startX = 0;
            float startY = 0;
            for (int i = 0; i < paths.Length; i++)
            {
                PathCommand command = new PathCommand(paths[i], startX, startY);
                startX = command.EndX;
                startY = command.EndY;
                pathCommands.Add(command);
            }
        }

        private void Initialize()
        {
            pathCommands = new List<PathCommand>();
        }
        private string[] SplitMultiCommandSvgPath(string path)
        {
            MatchCollection matchList = Regex.Matches(path, @"([MmZzLlHhVvCcSsQqTtAa][^MmZzLlHhVvCcSsQqTtAa]*)");
            string[] paths = matchList.Cast<Match>().Select(match => match.Value).ToArray();

            return paths;
        }

    }
}
