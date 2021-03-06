﻿// Copyright (c) 2017 Andrey Ushkalov

// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System.Collections.Generic;
using System.Globalization;
using ResourceProvider;

namespace SampleApplication.Infrastructure
{
    /// <summary>
    /// Константы приложения
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// Словарь с названиями культур
        /// </summary>
        public static readonly ResourceDictionaryInfo CultureInfoNamesDictionary = new ResourceDictionaryInfo("CULTURE_DICTIONARY", "pack://application:,,,/SampleApplication;component/Resources/CultureInfoNamesDictionary.xaml");

        /// <summary>
        /// Словарь со строками
        /// </summary>
        public static readonly ResourceDictionaryInfo StringDictionary = new ResourceDictionaryInfo("DICTIONARY1",
            CultureInfo.GetCultureInfo("en-US"),
            new Dictionary<CultureInfo, string>
            {
                {
                    CultureInfo.GetCultureInfo("en-US"),
                    "pack://application:,,,/SampleApplication;component/Resources/en-US/StringDictionary.xaml"
                },
                {
                    CultureInfo.GetCultureInfo("ru-RU"),
                    "pack://application:,,,/SampleApplication;component/Resources/ru-RU/StringDictionary.xaml"
                }
            });
    }
}
