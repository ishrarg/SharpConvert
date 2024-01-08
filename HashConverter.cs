﻿using System;
    /// <summary>
    /// A static class that provides methods for converting data into hash values.
    /// </summary>
    public static class HashConverter

        /// <summary>
        /// Converts a string to its MD5 hash representation.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The MD5 hash representation of the input string.</returns>
        public static string ToMD5(this string input, System.Text.Encoding encoding)
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

        /// <summary>
        /// Converts a string to its SHA1 hash value using the specified encoding.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The SHA1 hash value of the input string.</returns>
        public static string ToSHA1(this string input, System.Text.Encoding encoding)
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

        /// <summary>
        /// Converts a string to its SHA256 hash value.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The SHA256 hash value of the input string.</returns>
        public static string ToSHA256(this string input, System.Text.Encoding encoding)

        /// <summary>
        /// Converts a string to its SHA384 hash value using the specified encoding.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The SHA384 hash value of the input string.</returns>
        public static string ToSHA384(this string input, System.Text.Encoding encoding)

        /// <summary>
        /// Converts a string to its SHA512 hash representation.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <param name="encoding">The encoding to be used for converting the string to bytes.</param>
        /// <returns>The SHA512 hash representation of the input string.</returns>
        public static string ToSHA512(this string input, System.Text.Encoding encoding)

        /// <summary>
        /// Converts a byte array to a SHA1 hash string using the specified encoding.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <returns>The SHA1 hash string.</returns>
        public static string ToSHA1(this byte[] input, System.Text.Encoding encoding)
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

        /// <summary>
        /// Converts a byte array to its SHA256 hash representation.
        /// </summary>
        /// <param name="input">The byte array to be hashed.</param>
        /// <param name="encoding">The encoding used to convert the byte array to a string.</param>
        /// <returns>The SHA256 hash representation of the byte array.</returns>
        public static string ToSHA256(this byte[] input, System.Text.Encoding encoding)

        /// <summary>
        /// Converts a byte array to a SHA384 hash string using the specified encoding.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <returns>The SHA384 hash string.</returns>
        public static string ToSHA384(this byte[] input, System.Text.Encoding encoding)


        /// <summary>
        /// Converts a byte array to a SHA512 hash string using the specified encoding.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <param name="encoding">The encoding to use.</param>
        /// <returns>The SHA512 hash string.</returns>
        public static string ToSHA512(this byte[] input, System.Text.Encoding encoding)

        /// <summary>
        /// Converts a byte array to its MD5 hash representation.
        /// </summary>
        /// <param name="input">The byte array to be hashed.</param>
        /// <param name="encoding">The encoding used to convert the byte array to string.</param>
        /// <returns>The MD5 hash representation of the byte array as a string.</returns>
        public static string ToMD5(this byte[] input, System.Text.Encoding encoding)
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

        /// <summary>
        /// Converts a string to its MD5 hash value.
        /// </summary>
        /// <param name="input">The input string to be hashed.</param>
        /// <returns>The MD5 hash value of the input string.</returns>
        public static string ToMD5(this string input)
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

        /// <summary>
        /// Converts a string to its SHA1 hash value.
        /// </summary>
        /// <param name="input">The input string to be hashed.</param>
        /// <returns>The SHA1 hash value of the input string.</returns>
        public static string ToSHA1(this string input)
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

        /// <summary>
        /// Converts a string to its SHA256 hash value.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <returns>The SHA256 hash value of the input string.</returns>
        public static string ToSHA256(this string input)

        /// <summary>
        /// Converts a string to its SHA384 hash value.
        /// </summary>
        /// <param name="input">The input string to be hashed.</param>
        /// <returns>The SHA384 hash value of the input string.</returns>
        public static string ToSHA384(this string input)

        /// <summary>
        /// Converts a string to its SHA512 hash value.
        /// </summary>
        /// <param name="input">The string to be hashed.</param>
        /// <returns>The SHA512 hash value of the input string.</returns>
        public static string ToSHA512(this string input)

        /// <summary>
        /// Converts a byte array to its SHA1 hash representation.
        /// </summary>
        /// <param name="input">The byte array to be hashed.</param>
        /// <returns>The SHA1 hash representation of the input byte array.</returns>
        public static string ToSHA1(this byte[] input)
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();

        /// <summary>
        /// Converts a byte array to its SHA256 hash representation.
        /// </summary>
        /// <param name="input">The byte array to be hashed.</param>
        /// <returns>The SHA256 hash representation of the input byte array.</returns>
        public static string ToSHA256(this byte[] input)

        /// <summary>
        /// Converts a byte array to a SHA384 hash string.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <returns>The SHA384 hash string.</returns>
        public static string ToSHA384(this byte[] input)

        /// <summary>
        /// Converts a byte array to a SHA512 hash string.
        /// </summary>
        /// <param name="input">The byte array to convert.</param>
        /// <returns>The SHA512 hash string.</returns>
        public static string ToSHA512(this byte[] input)

        /// <summary>
        /// Converts a byte array to its MD5 hash value.
        /// </summary>
        /// <param name="input">The byte array to be hashed.</param>
        /// <returns>The MD5 hash value as a string.</returns>
        public static string ToMD5(this byte[] input)
                    // Get the hashed string.  
                    return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();