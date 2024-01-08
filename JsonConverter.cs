﻿using System;
    /// <summary>
    /// A static class that provides methods for converting objects to and from JSON format.
    /// </summary>
    public static class JsonConverter
        /// <summary>
        /// Converts a JSON string to an object of type T.
        /// </summary>
        /// <typeparam name="T">The type of the object to convert to.</typeparam>
        /// <param name="json">The JSON string to convert.</param>
        /// <returns>The deserialized object of type T.</returns>
        public static T JsonToObject<T>(string json)

        /// <summary>
        /// Converts an object to its JSON representation.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="obj">The object to convert.</param>
        /// <returns>The JSON representation of the object.</returns>
        public static string ObjectToJson<T>(T obj)