﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 
namespace IntegracaoPsP.Domain.Entities.Abastecimento
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class fichaAbastecimentoEmbarcacao {
        
        private string numeroDuvField;
        
        private embarcacao embarcacaoField;
        
        private abastecimentosAguaAbastecimentosAgua[] abastecimentosAguaField;
        
        private abastecimentosCombustivelAbastecimentosCombustivel[] abastecimentosCombustivelField;
        
        private abastecimentosLubrificanteAbastecimentosLubrificante[] abastecimentosLubrificanteField;
        
        private abastecimentosRealizadosCombustivelAbastecimentosRealizadosCombustivel[] abastecimentosRealizadosCombustivelField;
        
        /// <remarks/>
        public string numeroDuv {
            get {
                return this.numeroDuvField;
            }
            set {
                this.numeroDuvField = value;
            }
        }
        
        /// <remarks/>
        public embarcacao embarcacao {
            get {
                return this.embarcacaoField;
            }
            set {
                this.embarcacaoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("abastecimentosAgua", IsNullable=false)]
        public abastecimentosAguaAbastecimentosAgua[] abastecimentosAgua {
            get {
                return this.abastecimentosAguaField;
            }
            set {
                this.abastecimentosAguaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("abastecimentosCombustivel", IsNullable=false)]
        public abastecimentosCombustivelAbastecimentosCombustivel[] abastecimentosCombustivel {
            get {
                return this.abastecimentosCombustivelField;
            }
            set {
                this.abastecimentosCombustivelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("abastecimentosLubrificante", IsNullable=false)]
        public abastecimentosLubrificanteAbastecimentosLubrificante[] abastecimentosLubrificante {
            get {
                return this.abastecimentosLubrificanteField;
            }
            set {
                this.abastecimentosLubrificanteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("abastecimentosRealizadosCombustivel", IsNullable=false)]
        public abastecimentosRealizadosCombustivelAbastecimentosRealizadosCombustivel[] abastecimentosRealizadosCombustivel {
            get {
                return this.abastecimentosRealizadosCombustivelField;
            }
            set {
                this.abastecimentosRealizadosCombustivelField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class embarcacao {
        
        private string numeroIMOField;
        
        private string inscricaoField;
        
        private string nomeEmbarcacaoField;
        
        /// <remarks/>
        public string numeroIMO {
            get {
                return this.numeroIMOField;
            }
            set {
                this.numeroIMOField = value;
            }
        }
        
        /// <remarks/>
        public string inscricao {
            get {
                return this.inscricaoField;
            }
            set {
                this.inscricaoField = value;
            }
        }
        
        /// <remarks/>
        public string nomeEmbarcacao {
            get {
                return this.nomeEmbarcacaoField;
            }
            set {
                this.nomeEmbarcacaoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class abastecimentosAguaAbastecimentosAgua {
        
        private string empresaResponsavelField;
        
        private string qtdeField;
        
        private string dataHoraField;
        
        /// <remarks/>
        public string empresaResponsavel {
            get {
                return this.empresaResponsavelField;
            }
            set {
                this.empresaResponsavelField = value;
            }
        }
        
        /// <remarks/>
        public string qtde {
            get {
                return this.qtdeField;
            }
            set {
                this.qtdeField = value;
            }
        }
        
        /// <remarks/>
        public string dataHora {
            get {
                return this.dataHoraField;
            }
            set {
                this.dataHoraField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class abastecimentosCombustivelAbastecimentosCombustivel {
        
        private string empresaResponsavelField;
        
        private string qtdeField;
        
        private string dataHoraField;
        
        /// <remarks/>
        public string empresaResponsavel {
            get {
                return this.empresaResponsavelField;
            }
            set {
                this.empresaResponsavelField = value;
            }
        }
        
        /// <remarks/>
        public string qtde {
            get {
                return this.qtdeField;
            }
            set {
                this.qtdeField = value;
            }
        }
        
        /// <remarks/>
        public string dataHora {
            get {
                return this.dataHoraField;
            }
            set {
                this.dataHoraField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class abastecimentosLubrificanteAbastecimentosLubrificante {
        
        private string empresaResponsavelField;
        
        private string qtdeField;
        
        private string dataHoraField;
        
        /// <remarks/>
        public string empresaResponsavel {
            get {
                return this.empresaResponsavelField;
            }
            set {
                this.empresaResponsavelField = value;
            }
        }
        
        /// <remarks/>
        public string qtde {
            get {
                return this.qtdeField;
            }
            set {
                this.qtdeField = value;
            }
        }
        
        /// <remarks/>
        public string dataHora {
            get {
                return this.dataHoraField;
            }
            set {
                this.dataHoraField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    public partial class abastecimentosRealizadosCombustivelAbastecimentosRealizadosCombustivel {
        
        private string orgaoField;
        
        private string localField;
        
        private string dataHoraInicioField;
        
        private string dataHoraFimField;
        
        private string produtoField;
        
        private string qtdeField;
        
        private string abastecedorField;
        
        private string transportadoraField;
        
        /// <remarks/>
        public string orgao {
            get {
                return this.orgaoField;
            }
            set {
                this.orgaoField = value;
            }
        }
        
        /// <remarks/>
        public string local {
            get {
                return this.localField;
            }
            set {
                this.localField = value;
            }
        }
        
        /// <remarks/>
        public string dataHoraInicio {
            get {
                return this.dataHoraInicioField;
            }
            set {
                this.dataHoraInicioField = value;
            }
        }
        
        /// <remarks/>
        public string dataHoraFim {
            get {
                return this.dataHoraFimField;
            }
            set {
                this.dataHoraFimField = value;
            }
        }
        
        /// <remarks/>
        public string produto {
            get {
                return this.produtoField;
            }
            set {
                this.produtoField = value;
            }
        }
        
        /// <remarks/>
        public string qtde {
            get {
                return this.qtdeField;
            }
            set {
                this.qtdeField = value;
            }
        }
        
        /// <remarks/>
        public string abastecedor {
            get {
                return this.abastecedorField;
            }
            set {
                this.abastecedorField = value;
            }
        }
        
        /// <remarks/>
        public string transportadora {
            get {
                return this.transportadoraField;
            }
            set {
                this.transportadoraField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class abastecimentosAgua {
        
        private abastecimentosAguaAbastecimentosAgua[] abastecimentosAgua1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("abastecimentosAgua")]
        public abastecimentosAguaAbastecimentosAgua[] abastecimentosAgua1 {
            get {
                return this.abastecimentosAgua1Field;
            }
            set {
                this.abastecimentosAgua1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class abastecimentosCombustivel {
        
        private abastecimentosCombustivelAbastecimentosCombustivel[] abastecimentosCombustivel1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("abastecimentosCombustivel")]
        public abastecimentosCombustivelAbastecimentosCombustivel[] abastecimentosCombustivel1 {
            get {
                return this.abastecimentosCombustivel1Field;
            }
            set {
                this.abastecimentosCombustivel1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class abastecimentosLubrificante {
        
        private abastecimentosLubrificanteAbastecimentosLubrificante[] abastecimentosLubrificante1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("abastecimentosLubrificante")]
        public abastecimentosLubrificanteAbastecimentosLubrificante[] abastecimentosLubrificante1 {
            get {
                return this.abastecimentosLubrificante1Field;
            }
            set {
                this.abastecimentosLubrificante1Field = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class abastecimentosRealizadosCombustivel {
        
        private abastecimentosRealizadosCombustivelAbastecimentosRealizadosCombustivel[] abastecimentosRealizadosCombustivel1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("abastecimentosRealizadosCombustivel")]
        public abastecimentosRealizadosCombustivelAbastecimentosRealizadosCombustivel[] abastecimentosRealizadosCombustivel1 {
            get {
                return this.abastecimentosRealizadosCombustivel1Field;
            }
            set {
                this.abastecimentosRealizadosCombustivel1Field = value;
            }
        }
    }
}
