﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Genesis.Generation.Templates
{
    public static class TemplateLoader
    {
        public static IGeneratorTemplate LoadTemplateFor(IGenerator generator)
        {
            var templateFilePath = Path.Combine(Environment.CurrentDirectory, generator.GetType().Name + ".gen"); //TODO: hard coded path

            if (!File.Exists(templateFilePath))
                throw new FileNotFoundException(templateFilePath);

            var contents = File.ReadAllText(templateFilePath);
            return new StringTemplate(contents);
        }
    }
}
