// --------------------------------------------------------------------------------------------------------------------
// <auto-generated> 
//   This code was generated by a T4 template. 
//
//   Changes to this file may cause incorrect behavior and will be lost if 
//   the code is regenerated. 
// </auto-generated>
// <copyright file="ElectricCurrent.cs" company="QuantityTypes">
//   Copyright (c) 2014 QuantityTypes contributors
// </copyright>
// <summary>
//   Represents the electric current quantity.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace QuantityTypes
{
    using System;
#if !PCL
    using System.ComponentModel;
#endif
    using System.Globalization;
    using System.Runtime.Serialization;
    using System.Xml.Serialization;

    /// <summary>
    /// Represents the electric current quantity.
    /// </summary>
    [DataContract]
#if !PCL
    [Serializable]
    [TypeConverter(typeof(QuantityTypeConverter<ElectricCurrent>))]
#endif
    public partial struct ElectricCurrent : IQuantity<ElectricCurrent>
    {
        /// <summary>
        /// The backing field for the <see cref="Ampere" /> property.
        /// </summary>
        private static readonly ElectricCurrent AmpereField = new ElectricCurrent(1);

        /// <summary>
        /// The value.
        /// </summary>
        private double value;

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent"/> struct.
        /// </summary>
        /// <param name="value">
        /// The value. 
        /// </param>
        public ElectricCurrent(double value)
        {
            this.value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ElectricCurrent"/> struct.
        /// </summary>
        /// <param name="value">
        /// The value. 
        /// </param>
        /// <param name="unitProvider">
        /// The unit provider. 
        /// </param>
        public ElectricCurrent(string value, IUnitProvider unitProvider = null)
        {
            this.value = Parse(value, unitProvider ?? UnitProvider.Default).value;
        }

        /// <summary>
        /// Gets the "A" unit.
        /// </summary>
        [Unit("A", true)]
        public static ElectricCurrent Ampere 
        { 
            get { return AmpereField; } 
        }

        /// <summary>
        /// Gets or sets the electric current as a string.
        /// </summary>
        /// <value>The string.</value>
        /// <remarks>
        /// This property is used for XML serialization.
        /// </remarks>
        [XmlText]
        [DataMember]
        public string XmlValue
        {
            get
            {
                // Use round-trip format
                return this.ToString("R", CultureInfo.InvariantCulture);
            }

            set
            {
                this.value = Parse(value, CultureInfo.InvariantCulture).value;
            }
        }

        /// <summary>
        /// Gets the value of the electric current in the base unit.
        /// </summary>
        public double Value
        {
            get
            {
                return this.value;
            }
        }

        /// <summary>
        /// Converts a string representation of a quantity in a specific culture-specific format with a specific unit provider.
        /// </summary>
        /// <param name="input">
        /// A string that contains the quantity to convert. 
        /// </param>
        /// <param name="provider">
        /// An object that supplies culture-specific formatting information about <paramref name="input" />. If not specified, the culture of the default <see cref="UnitProvider" /> is used. 
        /// </param>
        /// <param name="unitProvider">
        /// The unit provider. If not specified, the default <see cref="UnitProvider" /> is used.
        /// </param>
        /// <returns>
        /// A <see cref="ElectricCurrent"/> that represents the quantity in <paramref name="input" />. 
        /// </returns>
        public static ElectricCurrent Parse(string input, IFormatProvider provider = null, IUnitProvider unitProvider = null)
        {
            if (unitProvider == null)
            {
                unitProvider = provider as IUnitProvider ?? UnitProvider.Default;
            }

            ElectricCurrent value;
            if (!unitProvider.TryParse(input, provider, out value))
            {
                throw new FormatException("Invalid format.");
            }

            return value;
        }

        /// <summary>
        /// Converts a string representation of a quantity with a specific unit provider.
        /// </summary>
        /// <param name="input">
        /// A string that contains the quantity to convert. 
        /// </param>
        /// <param name="unitProvider">
        /// The unit provider. If not specified, the default <see cref="UnitProvider" /> is used.
        /// </param>
        /// <returns>
        /// A <see cref="ElectricCurrent"/> that represents the quantity in <paramref name="input" />. 
        /// </returns>
        public static ElectricCurrent Parse(string input, IUnitProvider unitProvider)
        {
            if (unitProvider == null)
            {
                unitProvider = UnitProvider.Default;
            }

            ElectricCurrent value;
            if (!unitProvider.TryParse(input, unitProvider.Culture, out value))
            {
                throw new FormatException("Invalid format.");
            }

            return value;
        }

        /// <summary>
        /// Tries to parse the specified string.
        /// </summary>
        /// <param name="input">The input string.</param>
        /// <param name="provider">The format provider.</param>
        /// <param name="unitProvider">The unit provider.</param>
        /// <param name="result">The result.</param>
        /// <returns><c>true</c> if the string was parsed, <c>false</c> otherwise.</returns>
        public static bool TryParse(string input, IFormatProvider provider, IUnitProvider unitProvider, out ElectricCurrent result)
        {
            if (unitProvider == null)
            {
                unitProvider = provider as IUnitProvider ?? UnitProvider.Default;
            }

            return unitProvider.TryParse(input, provider, out result);
        }

        /// <summary>
        /// Parses the specified JSON string.
        /// </summary>
        /// <param name="input">The JSON input.</param>
        /// <returns>
        /// The <see cref="ElectricCurrent"/> .
        /// </returns>
        public static ElectricCurrent ParseJson(string input)
        {
            return Parse(input, CultureInfo.InvariantCulture);
        }

        /// <summary>
        /// Implements the operator +.
        /// </summary>
        /// <param name="x">
        /// The first value. 
        /// </param>
        /// <param name="y">
        /// The second value. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static ElectricCurrent operator +(ElectricCurrent x, ElectricCurrent y)
        {
            return new ElectricCurrent(x.value + y.value);
        }

        /// <summary>
        /// Implements the operator /.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static ElectricCurrent operator /(ElectricCurrent x, double y)
        {
            return new ElectricCurrent(x.value / y);
        }

        /// <summary>
        /// Implements the operator /.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static double operator /(ElectricCurrent x, ElectricCurrent y)
        {
            return x.value / y.value;
        }

        /// <summary>
        /// Implements the operator ==.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static bool operator ==(ElectricCurrent x, ElectricCurrent y)
        {
            return x.value.Equals(y.value);
        }

        /// <summary>
        /// Implements the operator &gt;.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static bool operator >(ElectricCurrent x, ElectricCurrent y)
        {
            return x.value > y.value;
        }

        /// <summary>
        /// Implements the operator &gt;=.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static bool operator >=(ElectricCurrent x, ElectricCurrent y)
        {
            return x.value >= y.value;
        }

        /// <summary>
        /// Implements the operator !=.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static bool operator !=(ElectricCurrent x, ElectricCurrent y)
        {
            return !x.value.Equals(y.value);
        }

        /// <summary>
        /// Implements the operator &lt;.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static bool operator <(ElectricCurrent x, ElectricCurrent y)
        {
            return x.value < y.value;
        }

        /// <summary>
        /// Implements the operator &lt;=.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static bool operator <=(ElectricCurrent x, ElectricCurrent y)
        {
            return x.value <= y.value;
        }

        /// <summary>
        /// Implements the operator *.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static ElectricCurrent operator *(double x, ElectricCurrent y)
        {
            return new ElectricCurrent(x * y.value);
        }

        /// <summary>
        /// Implements the operator *.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static ElectricCurrent operator *(ElectricCurrent x, double y)
        {
            return new ElectricCurrent(x.value * y);
        }

        /// <summary>
        /// Implements the operator -.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <param name="y">
        /// The y. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static ElectricCurrent operator -(ElectricCurrent x, ElectricCurrent y)
        {
            return new ElectricCurrent(x.value - y.value);
        }

        /// <summary>
        /// Implements the unary plus operator.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static ElectricCurrent operator +(ElectricCurrent x)
        {
            return new ElectricCurrent(x.value);
        }

        /// <summary>
        /// Implements the unary minus operator.
        /// </summary>
        /// <param name="x">
        /// The x. 
        /// </param>
        /// <returns>
        /// The result of the operator. 
        /// </returns>
        public static ElectricCurrent operator -(ElectricCurrent x)
        {
            return new ElectricCurrent(-x.value);
        }

        /// <summary>
        /// Compares this instance to the specified <see cref="ElectricCurrent"/> and returns an indication of their relative values.
        /// </summary>
        /// <param name="other">
        /// The other <see cref="ElectricCurrent"/> . 
        /// </param>
        /// <returns>
        /// A signed number indicating the relative values of this instance and the other value. 
        /// </returns>
        public int CompareTo(ElectricCurrent other)
        {
            return this.value.CompareTo(other.value);
        }

        /// <summary>
        /// Compares the current instance with another object of the same type and returns an integer that indicates whether the 
        /// current instance precedes, follows, or occurs in the same position in the sort order as the other object.
        /// </summary>
        /// <param name="obj">An object to compare with this instance.</param>
        /// <returns>
        /// A value that indicates the relative order of the objects being compared. The return value has these meanings: 
        /// Value Meaning Less than zero This instance is less than <paramref name="obj" />. Zero This instance is equal to 
        /// <paramref name="obj" />. Greater than zero This instance is greater than <paramref name="obj" />.
        /// </returns>
        public int CompareTo(object obj)
        {
            return this.CompareTo((ElectricCurrent)obj);
        }

        /// <summary>
        /// Converts the quantity to the specified unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <returns>The amount of the specified unit.</returns>
        double IQuantity.ConvertTo(IQuantity unit)
        {
            return this.ConvertTo((ElectricCurrent)unit);
        }

        /// <summary>
        /// Converts to the specified unit.
        /// </summary>
        /// <param name="unit">
        /// The unit. 
        /// </param>
        /// <returns>
        /// The value in the specified unit. 
        /// </returns>
        public double ConvertTo(ElectricCurrent unit)
        {
            return this.value / unit.Value;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">
        /// The <see cref="System.Object"/> to compare with this instance. 
        /// </param>
        /// <returns>
        /// <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c> . 
        /// </returns>
        public override bool Equals(object obj)
        {
            if (obj is ElectricCurrent)
            {
              return this.Equals((ElectricCurrent)obj);
            }

            return false;
        }

        /// <summary>
        /// Determines if the specified <see cref="ElectricCurrent"/> is equal to this instance.
        /// </summary>
        /// <param name="other">
        /// The other <see cref="ElectricCurrent"/> . 
        /// </param>
        /// <returns>
        /// True if the values are equal. 
        /// </returns>
        public bool Equals(ElectricCurrent other)
        {
            return this.value.Equals(other.value);
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
        /// </returns>
        public override int GetHashCode()
        {
            return this.Value.GetHashCode();
        }

        /// <summary>
        /// Multiplies by the specified number.
        /// </summary>
        /// <param name="x">The number.</param>
        /// <returns>The new quantity.</returns>
        public IQuantity MultiplyBy(double x)
        {
            return this * x;
        }

        /// <summary>
        /// Adds the specified quantity.
        /// </summary>
        /// <param name="x">The quantity to add.</param>
        /// <returns>The sum.</returns>
        public IQuantity Add(IQuantity x)
        {
            if (!(x is ElectricCurrent))
            {
                throw new InvalidOperationException("Can only add quantities of the same types.");
            }

            return new ElectricCurrent(this.value + x.Value);
        }

        /// <summary>
        /// Sets the value from the specified string.
        /// </summary>
        /// <param name="s">
        /// The s. 
        /// </param>
        /// <param name="provider">
        /// The provider. 
        /// </param>
        public void SetFromString(string s, IUnitProvider provider)
        {
            this.value = Parse(s, provider).value;
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance. 
        /// </returns>
        public override string ToString()
        {
            return this.ToString(null, UnitProvider.Default);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <param name="format">
        /// The format. 
        /// </param>
        /// <param name="formatProvider">
        /// The format provider. 
        /// </param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance. 
        /// </returns>
        public string ToString(string format, IFormatProvider formatProvider = null)
        {
            var unitProvider = formatProvider as IUnitProvider ?? UnitProvider.Default; 

            return this.ToString(format, formatProvider, unitProvider);
        }

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <param name="format">
        /// The format. 
        /// </param>
        /// <param name="formatProvider">
        /// The format provider. 
        /// </param>
        /// <param name="unitProvider">
        /// The unit provider. 
        /// </param>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance. 
        /// </returns>
        public string ToString(string format, IFormatProvider formatProvider, IUnitProvider unitProvider)
        {
            if (unitProvider == null)
            { 
                unitProvider = formatProvider as IUnitProvider ?? UnitProvider.Default; 
            }

            return unitProvider.Format(format, formatProvider, this);
        }
    }
}