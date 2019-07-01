[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
[assembly:System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"b132f6de-d410-4134-a8c0-85a46cfca8e9,", Version=@"1.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write18_XmlHelper(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"XmlHelper", @"");
                return;
            }
            TopLevelElement();
            Write2_XmlHelper(@"XmlHelper", @"", ((global::XmlHelper)o), true, false);
        }

        public void Write19_DataStoreInfo(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"DataStoreInfo", @"");
                return;
            }
            TopLevelElement();
            Write3_DataStoreInfo(@"DataStoreInfo", @"", ((global::NotebookLibrary.DataStoreInfo)o), true, false);
        }

        public void Write20_Thing(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Thing", @"");
                return;
            }
            TopLevelElement();
            Write4_Thing(@"Thing", @"", ((global::NotebookLibrary.Thing)o), true, false);
        }

        public void Write21_LstInstallationMaterial(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LstInstallationMaterial", @"");
                return;
            }
            TopLevelElement();
            Write5_LstInstallationMaterial(@"LstInstallationMaterial", @"", ((global::NotebookLibrary.Models.LstInstallationMaterial)o), true, false);
        }

        public void Write22_Item(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LstInstallationMaterialQualifier", @"");
                return;
            }
            TopLevelElement();
            Write6_Item(@"LstInstallationMaterialQualifier", @"", ((global::NotebookLibrary.Models.LstInstallationMaterialQualifier)o), true, false);
        }

        public void Write23_AreaController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"AreaController", @"");
                return;
            }
            TopLevelElement();
            Write7_AreaController(@"AreaController", @"", ((global::NotebookLibrary.Controllers.AreaController)o), true, false);
        }

        public void Write24_GeospatialDataController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"GeospatialDataController", @"");
                return;
            }
            TopLevelElement();
            Write8_GeospatialDataController(@"GeospatialDataController", @"", ((global::NotebookLibrary.Controllers.GeospatialDataController)o), true, false);
        }

        public void Write25_LocusController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LocusController", @"");
                return;
            }
            TopLevelElement();
            Write9_LocusController(@"LocusController", @"", ((global::NotebookLibrary.Controllers.LocusController)o), true, false);
        }

        public void Write26_Item(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LstArchitecturalConstructionStyleController", @"");
                return;
            }
            TopLevelElement();
            Write10_Item(@"LstArchitecturalConstructionStyleController", @"", ((global::NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController)o), true, false);
        }

        public void Write27_Item(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LstArchitecturalConstructionSupportController", @"");
                return;
            }
            TopLevelElement();
            Write11_Item(@"LstArchitecturalConstructionSupportController", @"", ((global::NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController)o), true, false);
        }

        public void Write28_ObjectController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ObjectController", @"");
                return;
            }
            TopLevelElement();
            Write12_ObjectController(@"ObjectController", @"", ((global::NotebookLibrary.Controllers.ObjectController)o), true, false);
        }

        public void Write29_PotteryBucketController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"PotteryBucketController", @"");
                return;
            }
            TopLevelElement();
            Write13_PotteryBucketController(@"PotteryBucketController", @"", ((global::NotebookLibrary.Controllers.PotteryBucketController)o), true, false);
        }

        public void Write30_SiteController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"SiteController", @"");
                return;
            }
            TopLevelElement();
            Write14_SiteController(@"SiteController", @"", ((global::NotebookLibrary.Controllers.SiteController)o), true, false);
        }

        public void Write31_SquareController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"SquareController", @"");
                return;
            }
            TopLevelElement();
            Write15_SquareController(@"SquareController", @"", ((global::NotebookLibrary.Controllers.SquareController)o), true, false);
        }

        public void Write32_SupervisorController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"SupervisorController", @"");
                return;
            }
            TopLevelElement();
            Write16_SupervisorController(@"SupervisorController", @"", ((global::NotebookLibrary.Controllers.SupervisorController)o), true, false);
        }

        public void Write33_TeamController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"TeamController", @"");
                return;
            }
            TopLevelElement();
            Write17_TeamController(@"TeamController", @"", ((global::NotebookLibrary.Controllers.TeamController)o), true, false);
        }

        void Write17_TeamController(string n, string ns, global::NotebookLibrary.Controllers.TeamController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.TeamController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"TeamController", @"");
            WriteEndElement(o);
        }

        void Write16_SupervisorController(string n, string ns, global::NotebookLibrary.Controllers.SupervisorController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.SupervisorController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"SupervisorController", @"");
            WriteEndElement(o);
        }

        void Write15_SquareController(string n, string ns, global::NotebookLibrary.Controllers.SquareController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.SquareController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"SquareController", @"");
            WriteEndElement(o);
        }

        void Write14_SiteController(string n, string ns, global::NotebookLibrary.Controllers.SiteController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.SiteController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"SiteController", @"");
            WriteEndElement(o);
        }

        void Write13_PotteryBucketController(string n, string ns, global::NotebookLibrary.Controllers.PotteryBucketController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.PotteryBucketController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PotteryBucketController", @"");
            WriteEndElement(o);
        }

        void Write12_ObjectController(string n, string ns, global::NotebookLibrary.Controllers.ObjectController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.ObjectController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ObjectController", @"");
            WriteEndElement(o);
        }

        void Write11_Item(string n, string ns, global::NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"LstArchitecturalConstructionSupportController", @"");
            WriteEndElement(o);
        }

        void Write10_Item(string n, string ns, global::NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"LstArchitecturalConstructionStyleController", @"");
            WriteEndElement(o);
        }

        void Write9_LocusController(string n, string ns, global::NotebookLibrary.Controllers.LocusController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.LocusController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"LocusController", @"");
            WriteEndElement(o);
        }

        void Write8_GeospatialDataController(string n, string ns, global::NotebookLibrary.Controllers.GeospatialDataController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.GeospatialDataController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"GeospatialDataController", @"");
            WriteEndElement(o);
        }

        void Write7_AreaController(string n, string ns, global::NotebookLibrary.Controllers.AreaController o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Controllers.AreaController)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"AreaController", @"");
            WriteEndElement(o);
        }

        void Write6_Item(string n, string ns, global::NotebookLibrary.Models.LstInstallationMaterialQualifier o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Models.LstInstallationMaterialQualifier)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"LstInstallationMaterialQualifier", @"");
            WriteElementStringRaw(@"Id", @"", System.Xml.XmlConvert.ToString((global::System.Byte)((global::System.Byte)o.@Id)));
            WriteElementString(@"Description", @"", ((global::System.String)o.@Description));
            WriteEndElement(o);
        }

        void Write5_LstInstallationMaterial(string n, string ns, global::NotebookLibrary.Models.LstInstallationMaterial o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Models.LstInstallationMaterial)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"LstInstallationMaterial", @"");
            WriteElementStringRaw(@"Id", @"", System.Xml.XmlConvert.ToString((global::System.Byte)((global::System.Byte)o.@Id)));
            WriteElementString(@"Description", @"", ((global::System.String)o.@Description));
            WriteEndElement(o);
        }

        void Write4_Thing(string n, string ns, global::NotebookLibrary.Thing o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Thing)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Thing", @"");
            WriteEndElement(o);
        }

        void Write3_DataStoreInfo(string n, string ns, global::NotebookLibrary.DataStoreInfo o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.DataStoreInfo)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"DataStoreInfo", @"");
            WriteElementString(@"Database", @"", ((global::System.String)o.@Database));
            WriteElementString(@"ServerAddress", @"", ((global::System.String)o.@ServerAddress));
            WriteElementString(@"ServerUsername", @"", ((global::System.String)o.@ServerUsername));
            WriteElementString(@"ServerPassword", @"", ((global::System.String)o.@ServerPassword));
            WriteEndElement(o);
        }

        void Write2_XmlHelper(string n, string ns, global::XmlHelper o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::XmlHelper)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"XmlHelper", @"");
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read18_XmlHelper() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id1_XmlHelper && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read2_XmlHelper(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":XmlHelper");
            }
            return (object)o;
        }

        public object Read19_DataStoreInfo() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id3_DataStoreInfo && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read3_DataStoreInfo(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":DataStoreInfo");
            }
            return (object)o;
        }

        public object Read20_Thing() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id4_Thing && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read4_Thing(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":Thing");
            }
            return (object)o;
        }

        public object Read21_LstInstallationMaterial() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id5_LstInstallationMaterial && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read5_LstInstallationMaterial(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":LstInstallationMaterial");
            }
            return (object)o;
        }

        public object Read22_Item() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id6_Item && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read6_Item(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":LstInstallationMaterialQualifier");
            }
            return (object)o;
        }

        public object Read23_AreaController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id7_AreaController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read7_AreaController(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":AreaController");
            }
            return (object)o;
        }

        public object Read24_GeospatialDataController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id8_GeospatialDataController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read8_GeospatialDataController(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":GeospatialDataController");
            }
            return (object)o;
        }

        public object Read25_LocusController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id9_LocusController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read9_LocusController(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":LocusController");
            }
            return (object)o;
        }

        public object Read26_Item() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id10_Item && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read10_Item(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":LstArchitecturalConstructionStyleController");
            }
            return (object)o;
        }

        public object Read27_Item() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id11_Item && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read11_Item(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":LstArchitecturalConstructionSupportController");
            }
            return (object)o;
        }

        public object Read28_ObjectController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id12_ObjectController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read12_ObjectController(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ObjectController");
            }
            return (object)o;
        }

        public object Read29_PotteryBucketController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id13_PotteryBucketController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read13_PotteryBucketController(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":PotteryBucketController");
            }
            return (object)o;
        }

        public object Read30_SiteController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id14_SiteController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read14_SiteController(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":SiteController");
            }
            return (object)o;
        }

        public object Read31_SquareController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id15_SquareController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read15_SquareController(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":SquareController");
            }
            return (object)o;
        }

        public object Read32_SupervisorController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id16_SupervisorController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read16_SupervisorController(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":SupervisorController");
            }
            return (object)o;
        }

        public object Read33_TeamController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id17_TeamController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read17_TeamController(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":TeamController");
            }
            return (object)o;
        }

        global::NotebookLibrary.Controllers.TeamController Read17_TeamController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_TeamController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.TeamController o;
            o = new global::NotebookLibrary.Controllers.TeamController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Controllers.SupervisorController Read16_SupervisorController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_SupervisorController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.SupervisorController o;
            o = new global::NotebookLibrary.Controllers.SupervisorController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations1 = 0;
            int readerCount1 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations1, ref readerCount1);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Controllers.SquareController Read15_SquareController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_SquareController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.SquareController o;
            o = new global::NotebookLibrary.Controllers.SquareController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations2, ref readerCount2);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Controllers.SiteController Read14_SiteController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_SiteController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.SiteController o;
            o = new global::NotebookLibrary.Controllers.SiteController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations3 = 0;
            int readerCount3 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations3, ref readerCount3);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Controllers.PotteryBucketController Read13_PotteryBucketController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_PotteryBucketController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.PotteryBucketController o;
            o = new global::NotebookLibrary.Controllers.PotteryBucketController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations4 = 0;
            int readerCount4 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations4, ref readerCount4);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Controllers.ObjectController Read12_ObjectController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_ObjectController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.ObjectController o;
            o = new global::NotebookLibrary.Controllers.ObjectController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations5 = 0;
            int readerCount5 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations5, ref readerCount5);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController Read11_Item(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController o;
            o = new global::NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations6 = 0;
            int readerCount6 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations6, ref readerCount6);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController Read10_Item(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController o;
            o = new global::NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations7 = 0;
            int readerCount7 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations7, ref readerCount7);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Controllers.LocusController Read9_LocusController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_LocusController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.LocusController o;
            o = new global::NotebookLibrary.Controllers.LocusController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations8 = 0;
            int readerCount8 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations8, ref readerCount8);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Controllers.GeospatialDataController Read8_GeospatialDataController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_GeospatialDataController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.GeospatialDataController o;
            o = new global::NotebookLibrary.Controllers.GeospatialDataController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations9 = 0;
            int readerCount9 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations9, ref readerCount9);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Controllers.AreaController Read7_AreaController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_AreaController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Controllers.AreaController o;
            o = new global::NotebookLibrary.Controllers.AreaController();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations10 = 0;
            int readerCount10 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations10, ref readerCount10);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Models.LstInstallationMaterialQualifier Read6_Item(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Models.LstInstallationMaterialQualifier o;
            o = new global::NotebookLibrary.Models.LstInstallationMaterialQualifier();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations11 = 0;
            int readerCount11 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id18_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Id = System.Xml.XmlConvert.ToByte(Reader.ReadElementString());
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id19_Description && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Description = Reader.ReadElementString();
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        UnknownNode((object)o, @":Id, :Description");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":Id, :Description");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations11, ref readerCount11);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Models.LstInstallationMaterial Read5_LstInstallationMaterial(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id5_LstInstallationMaterial && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Models.LstInstallationMaterial o;
            o = new global::NotebookLibrary.Models.LstInstallationMaterial();
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations12 = 0;
            int readerCount12 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id18_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Id = System.Xml.XmlConvert.ToByte(Reader.ReadElementString());
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id19_Description && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Description = Reader.ReadElementString();
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        UnknownNode((object)o, @":Id, :Description");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":Id, :Description");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations12, ref readerCount12);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.Thing Read4_Thing(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Thing && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Thing o;
            o = new global::NotebookLibrary.Thing();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations13 = 0;
            int readerCount13 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations13, ref readerCount13);
            }
            ReadEndElement();
            return o;
        }

        global::NotebookLibrary.DataStoreInfo Read3_DataStoreInfo(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_DataStoreInfo && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.DataStoreInfo o;
            o = new global::NotebookLibrary.DataStoreInfo();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations14 = 0;
            int readerCount14 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id20_Database && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Database = Reader.ReadElementString();
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id21_ServerAddress && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@ServerAddress = Reader.ReadElementString();
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id22_ServerUsername && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@ServerUsername = Reader.ReadElementString();
                            }
                            paramsRead[2] = true;
                            break;
                        }
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id23_ServerPassword && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@ServerPassword = Reader.ReadElementString();
                            }
                            paramsRead[3] = true;
                            break;
                        }
                        UnknownNode((object)o, @":Database, :ServerAddress, :ServerUsername, :ServerPassword");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":Database, :ServerAddress, :ServerUsername, :ServerPassword");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations14, ref readerCount14);
            }
            ReadEndElement();
            return o;
        }

        global::XmlHelper Read2_XmlHelper(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id1_XmlHelper && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::XmlHelper o;
            o = new global::XmlHelper();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations15 = 0;
            int readerCount15 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations15, ref readerCount15);
            }
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id6_Item;
        string id15_SquareController;
        string id11_Item;
        string id10_Item;
        string id18_Id;
        string id8_GeospatialDataController;
        string id19_Description;
        string id17_TeamController;
        string id4_Thing;
        string id2_Item;
        string id7_AreaController;
        string id22_ServerUsername;
        string id9_LocusController;
        string id16_SupervisorController;
        string id13_PotteryBucketController;
        string id21_ServerAddress;
        string id1_XmlHelper;
        string id12_ObjectController;
        string id14_SiteController;
        string id23_ServerPassword;
        string id5_LstInstallationMaterial;
        string id3_DataStoreInfo;
        string id20_Database;

        protected override void InitIDs() {
            id6_Item = Reader.NameTable.Add(@"LstInstallationMaterialQualifier");
            id15_SquareController = Reader.NameTable.Add(@"SquareController");
            id11_Item = Reader.NameTable.Add(@"LstArchitecturalConstructionSupportController");
            id10_Item = Reader.NameTable.Add(@"LstArchitecturalConstructionStyleController");
            id18_Id = Reader.NameTable.Add(@"Id");
            id8_GeospatialDataController = Reader.NameTable.Add(@"GeospatialDataController");
            id19_Description = Reader.NameTable.Add(@"Description");
            id17_TeamController = Reader.NameTable.Add(@"TeamController");
            id4_Thing = Reader.NameTable.Add(@"Thing");
            id2_Item = Reader.NameTable.Add(@"");
            id7_AreaController = Reader.NameTable.Add(@"AreaController");
            id22_ServerUsername = Reader.NameTable.Add(@"ServerUsername");
            id9_LocusController = Reader.NameTable.Add(@"LocusController");
            id16_SupervisorController = Reader.NameTable.Add(@"SupervisorController");
            id13_PotteryBucketController = Reader.NameTable.Add(@"PotteryBucketController");
            id21_ServerAddress = Reader.NameTable.Add(@"ServerAddress");
            id1_XmlHelper = Reader.NameTable.Add(@"XmlHelper");
            id12_ObjectController = Reader.NameTable.Add(@"ObjectController");
            id14_SiteController = Reader.NameTable.Add(@"SiteController");
            id23_ServerPassword = Reader.NameTable.Add(@"ServerPassword");
            id5_LstInstallationMaterial = Reader.NameTable.Add(@"LstInstallationMaterial");
            id3_DataStoreInfo = Reader.NameTable.Add(@"DataStoreInfo");
            id20_Database = Reader.NameTable.Add(@"Database");
        }
    }

    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    public sealed class XmlHelperSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"XmlHelper", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write18_XmlHelper(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read18_XmlHelper();
        }
    }

    public sealed class DataStoreInfoSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"DataStoreInfo", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write19_DataStoreInfo(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read19_DataStoreInfo();
        }
    }

    public sealed class ThingSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Thing", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write20_Thing(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read20_Thing();
        }
    }

    public sealed class LstInstallationMaterialSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LstInstallationMaterial", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write21_LstInstallationMaterial(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read21_LstInstallationMaterial();
        }
    }

    public sealed class LstInstallationMaterialQualifierSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LstInstallationMaterialQualifier", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write22_Item(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read22_Item();
        }
    }

    public sealed class AreaControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"AreaController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write23_AreaController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read23_AreaController();
        }
    }

    public sealed class GeospatialDataControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"GeospatialDataController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write24_GeospatialDataController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read24_GeospatialDataController();
        }
    }

    public sealed class LocusControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LocusController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write25_LocusController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read25_LocusController();
        }
    }

    public sealed class LstArchitecturalConstructionStyleControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LstArchitecturalConstructionStyleController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write26_Item(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read26_Item();
        }
    }

    public sealed class LstArchitecturalConstructionSupportControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LstArchitecturalConstructionSupportController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write27_Item(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read27_Item();
        }
    }

    public sealed class ObjectControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ObjectController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write28_ObjectController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read28_ObjectController();
        }
    }

    public sealed class PotteryBucketControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"PotteryBucketController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write29_PotteryBucketController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read29_PotteryBucketController();
        }
    }

    public sealed class SiteControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"SiteController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write30_SiteController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read30_SiteController();
        }
    }

    public sealed class SquareControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"SquareController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write31_SquareController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read31_SquareController();
        }
    }

    public sealed class SupervisorControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"SupervisorController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write32_SupervisorController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read32_SupervisorController();
        }
    }

    public sealed class TeamControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"TeamController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write33_TeamController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read33_TeamController();
        }
    }

    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.Hashtable readMethods = null;
        public override System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"XmlHelper::"] = @"Read18_XmlHelper";
                    _tmp[@"NotebookLibrary.DataStoreInfo::"] = @"Read19_DataStoreInfo";
                    _tmp[@"NotebookLibrary.Thing::"] = @"Read20_Thing";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterial::"] = @"Read21_LstInstallationMaterial";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterialQualifier::"] = @"Read22_Item";
                    _tmp[@"NotebookLibrary.Controllers.AreaController::"] = @"Read23_AreaController";
                    _tmp[@"NotebookLibrary.Controllers.GeospatialDataController::"] = @"Read24_GeospatialDataController";
                    _tmp[@"NotebookLibrary.Controllers.LocusController::"] = @"Read25_LocusController";
                    _tmp[@"NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController::"] = @"Read26_Item";
                    _tmp[@"NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController::"] = @"Read27_Item";
                    _tmp[@"NotebookLibrary.Controllers.ObjectController::"] = @"Read28_ObjectController";
                    _tmp[@"NotebookLibrary.Controllers.PotteryBucketController::"] = @"Read29_PotteryBucketController";
                    _tmp[@"NotebookLibrary.Controllers.SiteController::"] = @"Read30_SiteController";
                    _tmp[@"NotebookLibrary.Controllers.SquareController::"] = @"Read31_SquareController";
                    _tmp[@"NotebookLibrary.Controllers.SupervisorController::"] = @"Read32_SupervisorController";
                    _tmp[@"NotebookLibrary.Controllers.TeamController::"] = @"Read33_TeamController";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.Hashtable writeMethods = null;
        public override System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"XmlHelper::"] = @"Write18_XmlHelper";
                    _tmp[@"NotebookLibrary.DataStoreInfo::"] = @"Write19_DataStoreInfo";
                    _tmp[@"NotebookLibrary.Thing::"] = @"Write20_Thing";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterial::"] = @"Write21_LstInstallationMaterial";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterialQualifier::"] = @"Write22_Item";
                    _tmp[@"NotebookLibrary.Controllers.AreaController::"] = @"Write23_AreaController";
                    _tmp[@"NotebookLibrary.Controllers.GeospatialDataController::"] = @"Write24_GeospatialDataController";
                    _tmp[@"NotebookLibrary.Controllers.LocusController::"] = @"Write25_LocusController";
                    _tmp[@"NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController::"] = @"Write26_Item";
                    _tmp[@"NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController::"] = @"Write27_Item";
                    _tmp[@"NotebookLibrary.Controllers.ObjectController::"] = @"Write28_ObjectController";
                    _tmp[@"NotebookLibrary.Controllers.PotteryBucketController::"] = @"Write29_PotteryBucketController";
                    _tmp[@"NotebookLibrary.Controllers.SiteController::"] = @"Write30_SiteController";
                    _tmp[@"NotebookLibrary.Controllers.SquareController::"] = @"Write31_SquareController";
                    _tmp[@"NotebookLibrary.Controllers.SupervisorController::"] = @"Write32_SupervisorController";
                    _tmp[@"NotebookLibrary.Controllers.TeamController::"] = @"Write33_TeamController";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.Hashtable typedSerializers = null;
        public override System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp.Add(@"NotebookLibrary.Controllers.LocusController::", new LocusControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Thing::", new ThingSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController::", new LstArchitecturalConstructionStyleControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.PotteryBucketController::", new PotteryBucketControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.SiteController::", new SiteControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.GeospatialDataController::", new GeospatialDataControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Models.LstInstallationMaterial::", new LstInstallationMaterialSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.SquareController::", new SquareControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.AreaController::", new AreaControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.SupervisorController::", new SupervisorControllerSerializer());
                    _tmp.Add(@"XmlHelper::", new XmlHelperSerializer());
                    _tmp.Add(@"NotebookLibrary.Models.LstInstallationMaterialQualifier::", new LstInstallationMaterialQualifierSerializer());
                    _tmp.Add(@"NotebookLibrary.DataStoreInfo::", new DataStoreInfoSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController::", new LstArchitecturalConstructionSupportControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.TeamController::", new TeamControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.ObjectController::", new ObjectControllerSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::XmlHelper)) return true;
            if (type == typeof(global::NotebookLibrary.DataStoreInfo)) return true;
            if (type == typeof(global::NotebookLibrary.Thing)) return true;
            if (type == typeof(global::NotebookLibrary.Models.LstInstallationMaterial)) return true;
            if (type == typeof(global::NotebookLibrary.Models.LstInstallationMaterialQualifier)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.AreaController)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.GeospatialDataController)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.LocusController)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.ObjectController)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.PotteryBucketController)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.SiteController)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.SquareController)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.SupervisorController)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.TeamController)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::XmlHelper)) return new XmlHelperSerializer();
            if (type == typeof(global::NotebookLibrary.DataStoreInfo)) return new DataStoreInfoSerializer();
            if (type == typeof(global::NotebookLibrary.Thing)) return new ThingSerializer();
            if (type == typeof(global::NotebookLibrary.Models.LstInstallationMaterial)) return new LstInstallationMaterialSerializer();
            if (type == typeof(global::NotebookLibrary.Models.LstInstallationMaterialQualifier)) return new LstInstallationMaterialQualifierSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.AreaController)) return new AreaControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.GeospatialDataController)) return new GeospatialDataControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.LocusController)) return new LocusControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.LstArchitecturalConstructionStyleController)) return new LstArchitecturalConstructionStyleControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.LstArchitecturalConstructionSupportController)) return new LstArchitecturalConstructionSupportControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.ObjectController)) return new ObjectControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.PotteryBucketController)) return new PotteryBucketControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.SiteController)) return new SiteControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.SquareController)) return new SquareControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.SupervisorController)) return new SupervisorControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.TeamController)) return new TeamControllerSerializer();
            return null;
        }
    }
}
