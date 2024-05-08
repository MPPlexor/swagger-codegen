/* 
 * Swagger Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * OpenAPI spec version: 1.0.0
 * Contact: apiteam@swagger.io
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;
namespace IO.Swagger.Model
{
    /// <summary>
    /// SinglePetResponse
    /// </summary>
    [DataContract]
        public partial class SinglePetResponse :  IEquatable<SinglePetResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SinglePetResponse" /> class.
        /// </summary>
        /// <param name="pet">pet.</param>
        public SinglePetResponse(OneOfSinglePetResponsePet pet = default(OneOfSinglePetResponsePet))
        {
            this.Pet = pet;
        }
        
        /// <summary>
        /// Gets or Sets Pet
        /// </summary>
        [DataMember(Name="pet", EmitDefaultValue=false)]
        public OneOfSinglePetResponsePet Pet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SinglePetResponse {\n");
            sb.Append("  Pet: ").Append(Pet).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SinglePetResponse);
        }

        /// <summary>
        /// Returns true if SinglePetResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SinglePetResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SinglePetResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Pet == input.Pet ||
                    (this.Pet != null &&
                    this.Pet.Equals(input.Pet))
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
                if (this.Pet != null)
                    hashCode = hashCode * 59 + this.Pet.GetHashCode();
                return hashCode;
            }
        }
    }
}
