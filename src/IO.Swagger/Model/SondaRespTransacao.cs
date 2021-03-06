/* 
 * Saque e Pague Sonda
 *
 * Modelo de API para o serviço de sonda da Saque e Pague. Parceiro pode requisitar o último estado de uma transação (cancelada, confirmada ou pendente) através das chamadas desta API. Caso não encontre a transação, o serviço retorna o estado pendente.
 *
 * OpenAPI spec version: 1.1.1-sw2
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Objeto de resposta que contem o estado da transação sondada. Caso não encontre a transação vai retornar estado pendente.
    /// </summary>
    [DataContract]
    public partial class SondaRespTransacao :  IEquatable<SondaRespTransacao>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SondaRespTransacao" /> class.
        /// </summary>
        /// <param name="status">Status da transação nos sistemas da Saque e Pague (F &#x3D; confirmada, C &#x3D; cancelada, P &#x3D; pendente). Para casos de teste usar até 10 para retorno cancelado, até 20 para estado confirmado e o resto pendente..</param>
        public SondaRespTransacao(string status = default(string))
        {
            this.Status = status;
        }
        
        /// <summary>
        /// Status da transação nos sistemas da Saque e Pague (F &#x3D; confirmada, C &#x3D; cancelada, P &#x3D; pendente). Para casos de teste usar até 10 para retorno cancelado, até 20 para estado confirmado e o resto pendente.
        /// </summary>
        /// <value>Status da transação nos sistemas da Saque e Pague (F &#x3D; confirmada, C &#x3D; cancelada, P &#x3D; pendente). Para casos de teste usar até 10 para retorno cancelado, até 20 para estado confirmado e o resto pendente.</value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SondaRespTransacao {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as SondaRespTransacao);
        }

        /// <summary>
        /// Returns true if SondaRespTransacao instances are equal
        /// </summary>
        /// <param name="input">Instance of SondaRespTransacao to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SondaRespTransacao input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Status (string) pattern
            Regex regexStatus = new Regex(@"^[CFP]$", RegexOptions.CultureInvariant);
            if (false == regexStatus.Match(this.Status).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Status, must match a pattern of " + regexStatus, new [] { "Status" });
            }

            yield break;
        }
    }

}
