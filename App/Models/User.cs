using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class User
    {
        [JsonProperty(PropertyName = "id")]
        public string id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string name { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool deleted { get; set; }

        [JsonProperty(PropertyName = "isAdmin")]
        public bool isAdmin { get; set; }

        [JsonProperty(PropertyName = "userName")]
        public string userName { get; set; }

        [JsonProperty(PropertyName = "salutationName")]
        public object salutationName { get; set; }

        [JsonProperty(PropertyName = "firstName")]
        public string firstName { get; set; }

        [JsonProperty(PropertyName = "lastName")]
        public string lastName { get; set; }

        [JsonProperty(PropertyName = "isActive")]
        public bool isActive { get; set; }

        [JsonProperty(PropertyName = "isPortalUser")]
        public bool isPortalUser { get; set; }

        [JsonProperty(PropertyName = "isSuperAdmin")]
        public bool isSuperAdmin { get; set; }

        [JsonProperty(PropertyName = "title")]
        public object title { get; set; }

        [JsonProperty(PropertyName = "emailAddress")]
        public string emailAddress { get; set; }

        [JsonProperty(PropertyName = "phoneNumber")]
        public string phoneNumber { get; set; }

        [JsonProperty(PropertyName = "gender")]
        public object gender { get; set; }

        [JsonProperty(PropertyName = "createdAt")]
        public string createdAt { get; set; }

        [JsonProperty(PropertyName = "emailAnupam")]
        public string emailAnupam { get; set; }

        [JsonProperty(PropertyName = "cPF")]
        public string cPF { get; set; }

        [JsonProperty(PropertyName = "rG")]
        public string rG { get; set; }

        [JsonProperty(PropertyName = "apelido")]
        public object apelido { get; set; }

        [JsonProperty(PropertyName = "aprovaoGerente")]
        public bool aprovaoGerente { get; set; }

        [JsonProperty(PropertyName = "aprovaoRH")]
        public bool aprovaoRH { get; set; }

        [JsonProperty(PropertyName = "cRECI")]
        public string cRECI { get; set; }

        [JsonProperty(PropertyName = "endereo")]
        public string endereo { get; set; }

        [JsonProperty(PropertyName = "estadoCivil")]
        public string estadoCivil { get; set; }

        [JsonProperty(PropertyName = "validadeDoCRECI")]
        public string validadeDoCRECI { get; set; }

        [JsonProperty(PropertyName = "validadeDoEstgio")]
        public string validadeDoEstgio { get; set; }

        [JsonProperty(PropertyName = "contratoGeradoEnviado")]
        public bool contratoGeradoEnviado { get; set; }

        [JsonProperty(PropertyName = "ipCadastroLP")]
        public string ipCadastroLP { get; set; }

        [JsonProperty(PropertyName = "enderecoCep")]
        public string enderecoCep { get; set; }

        [JsonProperty(PropertyName = "enderecoEstado")]
        public string enderecoEstado { get; set; }

        [JsonProperty(PropertyName = "enderecoCidade")]
        public string enderecoCidade { get; set; }

        [JsonProperty(PropertyName = "sexo")]
        public string sexo { get; set; }

        [JsonProperty(PropertyName = "dataDeNascimento")]
        public object dataDeNascimento { get; set; }

        [JsonProperty(PropertyName = "integrao")]
        public bool integrao { get; set; }

        [JsonProperty(PropertyName = "crach")]
        public bool crach { get; set; }

        [JsonProperty(PropertyName = "antecedentes")]
        public bool antecedentes { get; set; }

        [JsonProperty(PropertyName = "consultaCreci")]
        public bool consultaCreci { get; set; }

        [JsonProperty(PropertyName = "anapro")]
        public bool anapro { get; set; }

        [JsonProperty(PropertyName = "bancoPaulista")]
        public bool bancoPaulista { get; set; }

        [JsonProperty(PropertyName = "gostariaDeRealizarAAprovaoRH")]
        public bool gostariaDeRealizarAAprovaoRH { get; set; }

        [JsonProperty(PropertyName = "cargo")]
        public string cargo { get; set; }

        [JsonProperty(PropertyName = "tempBaseUpdate")]
        public string tempBaseUpdate { get; set; }

        [JsonProperty(PropertyName = "status")]
        public string status { get; set; }

        [JsonProperty(PropertyName = "emailPessoal")]
        public string emailPessoal { get; set; }

        [JsonProperty(PropertyName = "emailAddressIsOptedOut")]
        public bool emailAddressIsOptedOut { get; set; }

        [JsonProperty(PropertyName = "defaultTeamId")]
        public string defaultTeamId { get; set; }

        [JsonProperty(PropertyName = "defaultTeamName")]
        public string defaultTeamName { get; set; }

        [JsonProperty(PropertyName = "contactId")]
        public object contactId { get; set; }

        [JsonProperty(PropertyName = "contactName")]
        public object contactName { get; set; }

        [JsonProperty(PropertyName = "avatarId")]
        public string avatarId { get; set; }

        [JsonProperty(PropertyName = "avatarName")]
        public string avatarName { get; set; }

        [JsonProperty(PropertyName = "createdById")]
        public string createdById { get; set; }

        [JsonProperty(PropertyName = "createdByName")]
        public string createdByName { get; set; }

        [JsonProperty(PropertyName = "gerenteId")]
        public string gerenteId { get; set; }

        [JsonProperty(PropertyName = "gerenteName")]
        public string gerenteName { get; set; }

    }
}
