/*
 * Courier API Reference
 *
 * The Courier REST API.
 *
 * The version of the OpenAPI document: 1.0.0
 * Contact: support@courier.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Com.Courier.Client.OpenAPIDateConverter;

namespace Com.Courier.Model
{
    /// <summary>
    /// Paging
    /// </summary>
    [DataContract(Name = "Paging")]
    public partial class Paging : IEquatable<Paging>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Paging" /> class.
        /// </summary>
        /// <param name="cursor">A unique identifier that allows for fetching the next set of objects. (default to &quot;MTU4OTQ5NTI1ODY4NywxLTVlYmRjNWRhLTEwODZlYWFjMWRmMjEwMTNjM2I0ZjVhMA&#x3D;&#x3D;&quot;).</param>
        /// <param name="more">Whether or not there are more message statuses that can be fetched. (default to true).</param>
        public Paging(string cursor = "MTU4OTQ5NTI1ODY4NywxLTVlYmRjNWRhLTEwODZlYWFjMWRmMjEwMTNjM2I0ZjVhMA==", bool more = true)
        {
            // use default value if no "cursor" provided
            this.Cursor = cursor ?? "MTU4OTQ5NTI1ODY4NywxLTVlYmRjNWRhLTEwODZlYWFjMWRmMjEwMTNjM2I0ZjVhMA==";
            this.More = more;
        }

        /// <summary>
        /// A unique identifier that allows for fetching the next set of objects.
        /// </summary>
        /// <value>A unique identifier that allows for fetching the next set of objects.</value>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string Cursor { get; set; }

        /// <summary>
        /// Whether or not there are more message statuses that can be fetched.
        /// </summary>
        /// <value>Whether or not there are more message statuses that can be fetched.</value>
        [DataMember(Name = "more", EmitDefaultValue = true)]
        public bool More { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Paging {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  More: ").Append(More).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Paging);
        }

        /// <summary>
        /// Returns true if Paging instances are equal
        /// </summary>
        /// <param name="input">Instance of Paging to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Paging input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cursor == input.Cursor ||
                    (this.Cursor != null &&
                    this.Cursor.Equals(input.Cursor))
                ) && 
                (
                    this.More == input.More ||
                    this.More.Equals(input.More)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Cursor != null)
                    hashCode = hashCode * 59 + this.Cursor.GetHashCode();
                hashCode = hashCode * 59 + this.More.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}