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
    [DataContract(Name = "inline_response_202")]
    public partial class InlineResponse202 : IEquatable<InlineResponse202>, IValidatableObject
    {
        public InlineResponse202(string requestId = default(string))
        {
            this.RequestId = requestId;
        }

        [DataMember(Name = "requestId", EmitDefaultValue = false)]
        public string RequestId { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse202 {\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        public override bool Equals(object input)
        {
            return this.Equals(input as InlineResponse202);
        }

        public bool Equals(InlineResponse202 input)
        {
            if (input == null)
                return false;

            return
                (
                    this.RequestId == input.RequestId ||
                    (this.RequestId != null &&
                    this.RequestId.Equals(input.RequestId))
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
                if (this.RequestId != null)
                    hashCode = hashCode * 59 + this.RequestId.GetHashCode();
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
