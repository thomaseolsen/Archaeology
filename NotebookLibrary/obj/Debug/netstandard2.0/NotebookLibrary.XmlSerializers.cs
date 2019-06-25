[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
[assembly:System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"440ae0d0-baa8-4b8e-bd74-532571f5f3e0,", Version=@"1.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write12_XmlHelper(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"XmlHelper", @"");
                return;
            }
            TopLevelElement();
            Write2_XmlHelper(@"XmlHelper", @"", ((global::XmlHelper)o), true, false);
        }

        public void Write13_DataStoreInfo(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"DataStoreInfo", @"");
                return;
            }
            TopLevelElement();
            Write3_DataStoreInfo(@"DataStoreInfo", @"", ((global::NotebookLibrary.DataStoreInfo)o), true, false);
        }

        public void Write14_Thing(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Thing", @"");
                return;
            }
            TopLevelElement();
            Write4_Thing(@"Thing", @"", ((global::NotebookLibrary.Thing)o), true, false);
        }

        public void Write15_LstInstallationMaterial(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LstInstallationMaterial", @"");
                return;
            }
            TopLevelElement();
            Write5_LstInstallationMaterial(@"LstInstallationMaterial", @"", ((global::NotebookLibrary.Models.LstInstallationMaterial)o), true, false);
        }

        public void Write16_Item(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LstInstallationMaterialQualifier", @"");
                return;
            }
            TopLevelElement();
            Write6_Item(@"LstInstallationMaterialQualifier", @"", ((global::NotebookLibrary.Models.LstInstallationMaterialQualifier)o), true, false);
        }

        public void Write17_AreaController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"AreaController", @"");
                return;
            }
            TopLevelElement();
            Write7_AreaController(@"AreaController", @"", ((global::NotebookLibrary.Controllers.AreaController)o), true, false);
        }

        public void Write18_SiteController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"SiteController", @"");
                return;
            }
            TopLevelElement();
            Write8_SiteController(@"SiteController", @"", ((global::NotebookLibrary.Controllers.SiteController)o), true, false);
        }

        public void Write19_SquareController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"SquareController", @"");
                return;
            }
            TopLevelElement();
            Write9_SquareController(@"SquareController", @"", ((global::NotebookLibrary.Controllers.SquareController)o), true, false);
        }

        public void Write20_SupervisorController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"SupervisorController", @"");
                return;
            }
            TopLevelElement();
            Write10_SupervisorController(@"SupervisorController", @"", ((global::NotebookLibrary.Controllers.SupervisorController)o), true, false);
        }

        public void Write21_TeamController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"TeamController", @"");
                return;
            }
            TopLevelElement();
            Write11_TeamController(@"TeamController", @"", ((global::NotebookLibrary.Controllers.TeamController)o), true, false);
        }

        void Write11_TeamController(string n, string ns, global::NotebookLibrary.Controllers.TeamController o, bool isNullable, bool needType) {
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

        void Write10_SupervisorController(string n, string ns, global::NotebookLibrary.Controllers.SupervisorController o, bool isNullable, bool needType) {
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

        void Write9_SquareController(string n, string ns, global::NotebookLibrary.Controllers.SquareController o, bool isNullable, bool needType) {
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

        void Write8_SiteController(string n, string ns, global::NotebookLibrary.Controllers.SiteController o, bool isNullable, bool needType) {
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

        public object Read12_XmlHelper() {
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

        public object Read13_DataStoreInfo() {
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

        public object Read14_Thing() {
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

        public object Read15_LstInstallationMaterial() {
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

        public object Read16_Item() {
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

        public object Read17_AreaController() {
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

        public object Read18_SiteController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id8_SiteController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read8_SiteController(true, true);
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

        public object Read19_SquareController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id9_SquareController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read9_SquareController(true, true);
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

        public object Read20_SupervisorController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id10_SupervisorController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read10_SupervisorController(true, true);
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

        public object Read21_TeamController() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id11_TeamController && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read11_TeamController(true, true);
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

        global::NotebookLibrary.Controllers.TeamController Read11_TeamController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_TeamController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
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

        global::NotebookLibrary.Controllers.SupervisorController Read10_SupervisorController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_SupervisorController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
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

        global::NotebookLibrary.Controllers.SquareController Read9_SquareController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_SquareController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
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

        global::NotebookLibrary.Controllers.SiteController Read8_SiteController(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_SiteController && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
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
            int whileIterations5 = 0;
            int readerCount5 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id12_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Id = System.Xml.XmlConvert.ToByte(Reader.ReadElementString());
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id13_Description && (object) Reader.NamespaceURI == (object)id2_Item)) {
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
                CheckReaderCount(ref whileIterations5, ref readerCount5);
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
            int whileIterations6 = 0;
            int readerCount6 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id12_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Id = System.Xml.XmlConvert.ToByte(Reader.ReadElementString());
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id13_Description && (object) Reader.NamespaceURI == (object)id2_Item)) {
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
                CheckReaderCount(ref whileIterations6, ref readerCount6);
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
            int whileIterations8 = 0;
            int readerCount8 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id14_Database && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Database = Reader.ReadElementString();
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id15_ServerAddress && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@ServerAddress = Reader.ReadElementString();
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id16_ServerUsername && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@ServerUsername = Reader.ReadElementString();
                            }
                            paramsRead[2] = true;
                            break;
                        }
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id17_ServerPassword && (object) Reader.NamespaceURI == (object)id2_Item)) {
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
                CheckReaderCount(ref whileIterations8, ref readerCount8);
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

        protected override void InitCallbacks() {
        }

        string id7_AreaController;
        string id13_Description;
        string id12_Id;
        string id2_Item;
        string id6_Item;
        string id16_ServerUsername;
        string id8_SiteController;
        string id4_Thing;
        string id3_DataStoreInfo;
        string id11_TeamController;
        string id17_ServerPassword;
        string id9_SquareController;
        string id5_LstInstallationMaterial;
        string id14_Database;
        string id10_SupervisorController;
        string id15_ServerAddress;
        string id1_XmlHelper;

        protected override void InitIDs() {
            id7_AreaController = Reader.NameTable.Add(@"AreaController");
            id13_Description = Reader.NameTable.Add(@"Description");
            id12_Id = Reader.NameTable.Add(@"Id");
            id2_Item = Reader.NameTable.Add(@"");
            id6_Item = Reader.NameTable.Add(@"LstInstallationMaterialQualifier");
            id16_ServerUsername = Reader.NameTable.Add(@"ServerUsername");
            id8_SiteController = Reader.NameTable.Add(@"SiteController");
            id4_Thing = Reader.NameTable.Add(@"Thing");
            id3_DataStoreInfo = Reader.NameTable.Add(@"DataStoreInfo");
            id11_TeamController = Reader.NameTable.Add(@"TeamController");
            id17_ServerPassword = Reader.NameTable.Add(@"ServerPassword");
            id9_SquareController = Reader.NameTable.Add(@"SquareController");
            id5_LstInstallationMaterial = Reader.NameTable.Add(@"LstInstallationMaterial");
            id14_Database = Reader.NameTable.Add(@"Database");
            id10_SupervisorController = Reader.NameTable.Add(@"SupervisorController");
            id15_ServerAddress = Reader.NameTable.Add(@"ServerAddress");
            id1_XmlHelper = Reader.NameTable.Add(@"XmlHelper");
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
            ((XmlSerializationWriter1)writer).Write12_XmlHelper(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read12_XmlHelper();
        }
    }

    public sealed class DataStoreInfoSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"DataStoreInfo", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write13_DataStoreInfo(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read13_DataStoreInfo();
        }
    }

    public sealed class ThingSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Thing", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write14_Thing(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read14_Thing();
        }
    }

    public sealed class LstInstallationMaterialSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LstInstallationMaterial", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write15_LstInstallationMaterial(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read15_LstInstallationMaterial();
        }
    }

    public sealed class LstInstallationMaterialQualifierSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LstInstallationMaterialQualifier", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write16_Item(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read16_Item();
        }
    }

    public sealed class AreaControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"AreaController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write17_AreaController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read17_AreaController();
        }
    }

    public sealed class SiteControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"SiteController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write18_SiteController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read18_SiteController();
        }
    }

    public sealed class SquareControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"SquareController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write19_SquareController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read19_SquareController();
        }
    }

    public sealed class SupervisorControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"SupervisorController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write20_SupervisorController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read20_SupervisorController();
        }
    }

    public sealed class TeamControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"TeamController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write21_TeamController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read21_TeamController();
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
                    _tmp[@"XmlHelper::"] = @"Read12_XmlHelper";
                    _tmp[@"NotebookLibrary.DataStoreInfo::"] = @"Read13_DataStoreInfo";
                    _tmp[@"NotebookLibrary.Thing::"] = @"Read14_Thing";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterial::"] = @"Read15_LstInstallationMaterial";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterialQualifier::"] = @"Read16_Item";
                    _tmp[@"NotebookLibrary.Controllers.AreaController::"] = @"Read17_AreaController";
                    _tmp[@"NotebookLibrary.Controllers.SiteController::"] = @"Read18_SiteController";
                    _tmp[@"NotebookLibrary.Controllers.SquareController::"] = @"Read19_SquareController";
                    _tmp[@"NotebookLibrary.Controllers.SupervisorController::"] = @"Read20_SupervisorController";
                    _tmp[@"NotebookLibrary.Controllers.TeamController::"] = @"Read21_TeamController";
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
                    _tmp[@"XmlHelper::"] = @"Write12_XmlHelper";
                    _tmp[@"NotebookLibrary.DataStoreInfo::"] = @"Write13_DataStoreInfo";
                    _tmp[@"NotebookLibrary.Thing::"] = @"Write14_Thing";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterial::"] = @"Write15_LstInstallationMaterial";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterialQualifier::"] = @"Write16_Item";
                    _tmp[@"NotebookLibrary.Controllers.AreaController::"] = @"Write17_AreaController";
                    _tmp[@"NotebookLibrary.Controllers.SiteController::"] = @"Write18_SiteController";
                    _tmp[@"NotebookLibrary.Controllers.SquareController::"] = @"Write19_SquareController";
                    _tmp[@"NotebookLibrary.Controllers.SupervisorController::"] = @"Write20_SupervisorController";
                    _tmp[@"NotebookLibrary.Controllers.TeamController::"] = @"Write21_TeamController";
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
                    _tmp.Add(@"NotebookLibrary.Thing::", new ThingSerializer());
                    _tmp.Add(@"XmlHelper::", new XmlHelperSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.AreaController::", new AreaControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.SiteController::", new SiteControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.SupervisorController::", new SupervisorControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.TeamController::", new TeamControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.DataStoreInfo::", new DataStoreInfoSerializer());
                    _tmp.Add(@"NotebookLibrary.Models.LstInstallationMaterialQualifier::", new LstInstallationMaterialQualifierSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.SquareController::", new SquareControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Models.LstInstallationMaterial::", new LstInstallationMaterialSerializer());
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
            if (type == typeof(global::NotebookLibrary.Controllers.SiteController)) return new SiteControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.SquareController)) return new SquareControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.SupervisorController)) return new SupervisorControllerSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.TeamController)) return new TeamControllerSerializer();
            return null;
        }
    }
}
