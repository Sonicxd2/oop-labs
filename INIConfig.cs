using System;
using System.Collections.Generic;
using System.IO;

namespace OOP
{
    public class INIConfig : Config
    {
        private string Path;

        public INIConfig(string path)
        {
            Path = path;
        }


        public string get(string section, string name)
        {
            var lines = File.ReadAllLines(Path);
            section = "[" + section + "]";
            string currentSection = "[]";
            foreach (var line in lines)
            {
                if (line.StartsWith("["))
                {
                    currentSection = line;
                    continue;
                }

                //comment
                if ((line.StartsWith(";")) || (!line.Contains("=") || (line.StartsWith("\\"))))
                {
                    continue;
                }

                if (section == currentSection)
                {
                    var values = line.Split("=");
                    string currentName = values[0].Replace(" ", "");
                    if (currentName == name)
                    {
                        return values[1].Split(";")[0].Replace(" ", "");
                    }
                }
            }

            throw new KeyNotFoundException();
        }

        public double getDouble(string section, string name)
        {
            var foundedValue = get(section, name);
            return Convert.ToDouble(foundedValue);
        }

        public int getInt(string section, string name)
        {
            var foundedValue = get(section, name);
            return Convert.ToInt32(foundedValue);
        }
    }
}