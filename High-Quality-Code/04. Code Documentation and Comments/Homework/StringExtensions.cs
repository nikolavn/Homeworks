
/// <copyright file="StringExtensions.cs" company="TelerikAcademy">
///     All rights reserved © Telerik Academy 2014
/// </copyright>


namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Contains extensions for the string class
    /// </summary>

    public static class StringExtensions
    {
        /// <summary>
        /// Method to get the MD5 hash of a string  
        /// </summary>
        /// <param name="input">System.String</param>
        /// <returns>MD5 hash of the given string</returns>
        
        public static string ToMD5Hash(this string input)
        {
            var md5Hash = MD5.Create();
            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            var builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// Method that verifies if string is a true value. Predefined true values are stored in array.
        /// </summary>
        /// <param name="input">System.String</param>
        /// <returns>
        /// True - If string represents predefined true value
        /// False - If string doesn't represent predefined true value
        /// </returns>

        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// Method that tries to convert input to 16-bit signed integer
        /// </summary>
        /// <param name="input">System.String</param>
        /// <returns>16-bit signed integer</returns>

        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// Method that tries to convert input to 32-bit signed integer
        /// </summary>
        /// <param name="input">System.String</param>
        /// <returns>32-bit signed integer</returns>

        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// Method that tries to convert inputted string to 64-bit signed integer.
        /// </summary>
        /// <param name="input">System.String variable</param>
        /// <returns>
        /// 64-bit signed integer.
        /// </returns>

        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// Method that tries to convert input to DateTime value.
        /// </summary>
        /// <param name="input">System.String</param>
        /// <returns>System.DateTime value.</returns>

        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// Method that capitalizes the first character of inputted string.
        /// </summary>
        /// <param name="input">System.String variable</param>
        /// <returns>
        /// String.
        /// </returns>
        /// <example>
        /// CapitalizeFirstLetter("hello!") --> "Hello!"
        /// </example>
            
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// Method to find a sub-string that is between given two sub-strings. Both given sub-strings should be after a user-submitted position.
        /// </summary>
        /// <param name="input">System.String</param>
        /// <param name="startString">System.String that is the start delimeter</param>
        /// <param name="endString">String that is the end delimeter</param>
        /// <param name="startFrom">Integer number that marks the position the search should start from.</param>
        /// <returns>System.String</returns>
        /// <example>
        /// GetStringBetween("Lorem ipsum dolor sit amet.","ips","sit", 4) --> "um dolor "
        /// GetStringBetween("Lorem ipsum dolor sit amet.","ips","sit", 10) --> Empty string
        /// </example>

        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }
        
        /// <summary>
        /// Method that converts string written in Bulgarian cyrillic letters to their corresponding latin translation.
        /// </summary>
        /// <param name="input">System.String variable</param>
        /// <returns>
        /// String.
        /// </returns>
        /// <example>
        /// ConvertCyrillicToLatinLetters("Щъркел") --> "Shturkel"
        /// </example>
        
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// Method that converts string written with latin to how it would be written with Bulgarian Phonetic Keyboard.
        /// </summary>
        /// <param name="input">System.String variable</param>
        /// <returns>
        /// String.
        /// </returns>
        /// <example>
        /// ConvertLatinToCyrillicKeyboard("Taco cat") --> "Тацо цат"
        /// </example>

        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// Method that converts string input to valid user name using regular expression<see cref="System.Text.RegularExpressions"/>. 
        /// Valid user name contains small latin letters, capital latin letters, digits, underscore and dot, all other characters are removed. 
        /// Method uses <see cref="ConvertCyrillicToLatinLetters"/> method to convert any cyrillic characters to latin ones.
        /// </summary>
        /// <param name="input">System.String variable</param>
        /// <returns>
        /// String.
        /// </returns>
        /// <example>
        /// ToValidUsername("ustanovka::p0") --> "ustanovkap0"
        /// </example>

        public static string ToValidLatinUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// Method that converts string input to valid file name using regular expression<see cref="System.Text.RegularExpressions"/>. 
        /// Valid file name contains small latin letters, capital latin letters, digits, underscore and dot and hyphon.Empty spaces are replaced with 
        /// hyphons and all other characters are removed. Method uses <see cref="ConvertCyrillicToLatinLetters"/> method to convert any cyrillic 
        /// characters to latin ones.
        /// </summary>
        /// <param name="input">System.String variable</param>
        /// <returns>
        /// String.
        /// </returns>
        /// <example>
        /// ToValidLatinFileName("ужасен file/nam3+be") --> "uzhasen-filenam3be"
        /// </example>

        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// Method extracts a specified number of characters starting from the beginning of the inputted string. If specified number is larger than
        /// the length of the string, the whole input string is returned.
        /// </summary>
        /// <param name="input">System.String variable</param>
        /// <param name="charsCount">Number of characters to extract.</param>
        /// <returns>
        /// String.
        /// </returns>
        /// <example>
        /// GetFirstCharacters("hello!",4) --> "hell"
        /// GetFirstCharacters("hello!",16) --> "hello!"
        /// </example>
        
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// Method that extracts the extension from a given file name.
        /// </summary>
        /// <param name="fileName">System.String varialbe that represents full file name</param>
        /// <returns>String, that is the file extension without the dot.</returns>
        /// <example>
        /// GetFileExtension("yaka_macka.png") --> "png"
        /// </example>
        
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// Method that links the file extension with the type of content that is in the file. The file extension is the key in a 
        /// Dictionary key-value pair. If the file extension is not in the Dictionary a default value is returned.
        /// </summary>
        /// <param name="fileExtension">System.String variable, that reprsents file extension.</param>
        /// <returns>
        /// String, that is content type.
        /// </returns>
        /// <example>
        /// ToContentType("png") --> "image/x-png"
        /// ToContentType("tiff") --> "application/octet-stream"
        /// </example>

        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// Converts a set of characters from the specified character array 
        /// into a sequence of bytes.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>
        /// A byte array containing the specified set of characters.
        /// </returns>

        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
