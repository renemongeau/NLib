﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="FieldHelperExtension.cs" company=".">
//   Copyright (c) Cloudlucky. All rights reserved.
//   http://www.cloudlucky.com
//   This code is licensed under the Microsoft Public License (Ms-PL)
//   See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace NLib.Reflection.Extensions
{
    using System;

    /// <summary>
    /// Defines extensions methods for <see cref="FieldHelper{T, TKey}"/>.
    /// </summary>
    public static class FieldHelperExtension
    {
        /// <summary>
        /// Sets the value of the field supported by the given object.
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <typeparam name="TKey">The type of the field.</typeparam>
        /// <param name="helper">The helper.</param>
        /// <param name="value">The value.</param>
        /// <returns>The reflection helper.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="helper"/> is null.</exception>
        public static ReflectionHelper<T> SetValue<T, TKey>(this FieldHelper<T, TKey> helper, TKey value)
        {
            Check.ArgumentNullException(helper, "helper");

            helper.FieldInfo.SetValue(helper.ReflectionHelper.Value, value);

            return helper.ReflectionHelper;
        }

        /// <summary>
        /// Gets the value of a field supported by a given object.
        /// </summary>
        /// <typeparam name="T">The type of the object</typeparam>
        /// <typeparam name="TKey">The type of the field.</typeparam>
        /// <param name="helper">The helper.</param>
        /// <returns>The value.</returns>
        /// <exception cref="ArgumentNullException"><paramref name="helper"/> is null.</exception>
        public static TKey GetValue<T, TKey>(this FieldHelper<T, TKey> helper)
        {
            Check.ArgumentNullException(helper, "helper");

            return (TKey)helper.FieldInfo.GetValue(helper.ReflectionHelper.Value);
        }
    }
}
