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
namespace IntegracaoPsP.Domain.Entities
{


    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
    public partial class fichaAcionamentoPreventivoMA {
        
        private string numeroDuvField;
        
        private string numeroIMOField;
        
        private string inscricaoField;
        
        private string nomePortoField;
        
        private string etapaField;
        
        private string indicadorRiscoField;
        
        private string avisoRiscoOperacionalField;
        
        private string dataHoraAcionamentoField;
        
        private cargaPerigosa[] cargasPerigosasField;
        
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
        public string nomePorto {
            get {
                return this.nomePortoField;
            }
            set {
                this.nomePortoField = value;
            }
        }
        
        /// <remarks/>
        public string etapa {
            get {
                return this.etapaField;
            }
            set {
                this.etapaField = value;
            }
        }
        
        /// <remarks/>
        public string indicadorRisco {
            get {
                return this.indicadorRiscoField;
            }
            set {
                this.indicadorRiscoField = value;
            }
        }
        
        /// <remarks/>
        public string avisoRiscoOperacional {
            get {
                return this.avisoRiscoOperacionalField;
            }
            set {
                this.avisoRiscoOperacionalField = value;
            }
        }
        
        /// <remarks/>
        public string dataHoraAcionamento {
            get {
                return this.dataHoraAcionamentoField;
            }
            set {
                this.dataHoraAcionamentoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("cargaPerigosa", IsNullable=false)]
        public cargaPerigosa[] cargasPerigosas {
            get {
                return this.cargasPerigosasField;
            }
            set {
                this.cargasPerigosasField = value;
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
    public partial class cargaPerigosa {
        
        private string contidaConteinerField;
        
        private string movimentadaEstadiaField;
        
        private string numeroPacoteField;
        
        private string especiePacoteField;
        
        private string classeField;
        
        private string divisaoRiscoField;
        
        private string codigoField;
        
        private string nomeTecnicoProdutoField;
        
        private string fichaEmergenciaField;
        
        private string pesoLiquidoField;
        
        private string poluenteMarinhoField;
        
        private string temperaturaProdutoField;
        
        private string pontoFulgorField;
        
        private string posicaoEstivagemField;
        
        private string prioridadeCodigoField;
        
        private string prioridadeMotivoField;
        
        private string numeroRefereciaField;
        
        private embalagensEnum tipoEmbalagemField;
        
        private string numeroFispqField;
        
        private string packingGroupField;
        
        private string qtdeItensField;
        
        private string qtdeVolumeField;
        
        private conteineresCargasPerigosasConteineresCargasPerigosas[] conteineresCargasPerigosasField;
        
        /// <remarks/>
        public string contidaConteiner {
            get {
                return this.contidaConteinerField;
            }
            set {
                this.contidaConteinerField = value;
            }
        }
        
        /// <remarks/>
        public string movimentadaEstadia {
            get {
                return this.movimentadaEstadiaField;
            }
            set {
                this.movimentadaEstadiaField = value;
            }
        }
        
        /// <remarks/>
        public string numeroPacote {
            get {
                return this.numeroPacoteField;
            }
            set {
                this.numeroPacoteField = value;
            }
        }
        
        /// <remarks/>
        public string especiePacote {
            get {
                return this.especiePacoteField;
            }
            set {
                this.especiePacoteField = value;
            }
        }
        
        /// <remarks/>
        public string classe {
            get {
                return this.classeField;
            }
            set {
                this.classeField = value;
            }
        }
        
        /// <remarks/>
        public string divisaoRisco {
            get {
                return this.divisaoRiscoField;
            }
            set {
                this.divisaoRiscoField = value;
            }
        }
        
        /// <remarks/>
        public string codigo {
            get {
                return this.codigoField;
            }
            set {
                this.codigoField = value;
            }
        }
        
        /// <remarks/>
        public string nomeTecnicoProduto {
            get {
                return this.nomeTecnicoProdutoField;
            }
            set {
                this.nomeTecnicoProdutoField = value;
            }
        }
        
        /// <remarks/>
        public string fichaEmergencia {
            get {
                return this.fichaEmergenciaField;
            }
            set {
                this.fichaEmergenciaField = value;
            }
        }
        
        /// <remarks/>
        public string pesoLiquido {
            get {
                return this.pesoLiquidoField;
            }
            set {
                this.pesoLiquidoField = value;
            }
        }
        
        /// <remarks/>
        public string poluenteMarinho {
            get {
                return this.poluenteMarinhoField;
            }
            set {
                this.poluenteMarinhoField = value;
            }
        }
        
        /// <remarks/>
        public string temperaturaProduto {
            get {
                return this.temperaturaProdutoField;
            }
            set {
                this.temperaturaProdutoField = value;
            }
        }
        
        /// <remarks/>
        public string pontoFulgor {
            get {
                return this.pontoFulgorField;
            }
            set {
                this.pontoFulgorField = value;
            }
        }
        
        /// <remarks/>
        public string posicaoEstivagem {
            get {
                return this.posicaoEstivagemField;
            }
            set {
                this.posicaoEstivagemField = value;
            }
        }
        
        /// <remarks/>
        public string prioridadeCodigo {
            get {
                return this.prioridadeCodigoField;
            }
            set {
                this.prioridadeCodigoField = value;
            }
        }
        
        /// <remarks/>
        public string prioridadeMotivo {
            get {
                return this.prioridadeMotivoField;
            }
            set {
                this.prioridadeMotivoField = value;
            }
        }
        
        /// <remarks/>
        public string numeroReferecia {
            get {
                return this.numeroRefereciaField;
            }
            set {
                this.numeroRefereciaField = value;
            }
        }
        
        /// <remarks/>
        public embalagensEnum tipoEmbalagem {
            get {
                return this.tipoEmbalagemField;
            }
            set {
                this.tipoEmbalagemField = value;
            }
        }
        
        /// <remarks/>
        public string numeroFispq {
            get {
                return this.numeroFispqField;
            }
            set {
                this.numeroFispqField = value;
            }
        }
        
        /// <remarks/>
        public string packingGroup {
            get {
                return this.packingGroupField;
            }
            set {
                this.packingGroupField = value;
            }
        }
        
        /// <remarks/>
        public string qtdeItens {
            get {
                return this.qtdeItensField;
            }
            set {
                this.qtdeItensField = value;
            }
        }
        
        /// <remarks/>
        public string qtdeVolume {
            get {
                return this.qtdeVolumeField;
            }
            set {
                this.qtdeVolumeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("conteineresCargasPerigosas", IsNullable=false)]
        public conteineresCargasPerigosasConteineresCargasPerigosas[] conteineresCargasPerigosas {
            get {
                return this.conteineresCargasPerigosasField;
            }
            set {
                this.conteineresCargasPerigosasField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    public enum embalagensEnum
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("6")]
        Item6,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("7")]
        Item7,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("8")]
        Item8,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("9")]
        Item9,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("10")]
        Item10,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("11")]
        Item11,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("12")]
        Item12,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("13")]
        Item13,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("14")]
        Item14,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("15")]
        Item15,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("16")]
        Item16,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("17")]
        Item17,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("18")]
        Item18,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("19")]
        Item19,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("20")]
        Item20,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("21")]
        Item21,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("22")]
        Item22,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("23")]
        Item23,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("24")]
        Item24,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("25")]
        Item25,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("26")]
        Item26,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("27")]
        Item27,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("28")]
        Item28,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("29")]
        Item29,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("30")]
        Item30,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("31")]
        Item31,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("32")]
        Item32,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("33")]
        Item33,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("34")]
        Item34,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("35")]
        Item35,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("36")]
        Item36,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("37")]
        Item37,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("38")]
        Item38,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("39")]
        Item39,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("40")]
        Item40,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("41")]
        Item41,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("42")]
        Item42,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("43")]
        Item43,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("44")]
        Item44,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("45")]
        Item45,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("46")]
        Item46,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("47")]
        Item47,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("48")]
        Item48,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("49")]
        Item49,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("50")]
        Item50,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("51")]
        Item51,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("52")]
        Item52,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("53")]
        Item53,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("54")]
        Item54,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("55")]
        Item55,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("56")]
        Item56,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("57")]
        Item57,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("58")]
        Item58,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("59")]
        Item59,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("60")]
        Item60,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("61")]
        Item61,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("62")]
        Item62,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("63")]
        Item63,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("64")]
        Item64,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("65")]
        Item65,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("66")]
        Item66,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("67")]
        Item67,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("68")]
        Item68,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("69")]
        Item69,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("70")]
        Item70,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("71")]
        Item71,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("72")]
        Item72,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("73")]
        Item73,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("74")]
        Item74,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("98")]
        Item98,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("99")]
        Item99,
    }

    /// <remarks/>

    public partial class conteineresCargasPerigosasConteineresCargasPerigosas {
        
        private string idConteinerCargaPerigosaField;
        
        private string isoCodeConteinerField;
        
        /// <remarks/>
        public string idConteinerCargaPerigosa {
            get {
                return this.idConteinerCargaPerigosaField;
            }
            set {
                this.idConteinerCargaPerigosaField = value;
            }
        }
        
        /// <remarks/>
        public string isoCodeConteiner {
            get {
                return this.isoCodeConteinerField;
            }
            set {
                this.isoCodeConteinerField = value;
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
    public partial class cargasPerigosas {
        
        private cargaPerigosa[] cargaPerigosaField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cargaPerigosa")]
        public cargaPerigosa[] cargaPerigosa {
            get {
                return this.cargaPerigosaField;
            }
            set {
                this.cargaPerigosaField = value;
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
    public partial class conteineresCargasPerigosas {
        
        private conteineresCargasPerigosasConteineresCargasPerigosas[] conteineresCargasPerigosas1Field;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("conteineresCargasPerigosas")]
        public conteineresCargasPerigosasConteineresCargasPerigosas[] conteineresCargasPerigosas1 {
            get {
                return this.conteineresCargasPerigosas1Field;
            }
            set {
                this.conteineresCargasPerigosas1Field = value;
            }
        }
    }
}
