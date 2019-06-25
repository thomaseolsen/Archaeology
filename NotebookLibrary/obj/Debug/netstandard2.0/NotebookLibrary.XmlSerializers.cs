[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
[assembly:System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"1b58de6a-3d35-40e7-aec5-6f2c27903622,", Version=@"1.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write9_XmlHelper(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"XmlHelper", @"");
                return;
            }
            TopLevelElement();
            Write2_XmlHelper(@"XmlHelper", @"", ((global::XmlHelper)o), true, false);
        }

        public void Write10_DataStoreInfo(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"DataStoreInfo", @"");
                return;
            }
            TopLevelElement();
            Write3_DataStoreInfo(@"DataStoreInfo", @"", ((global::NotebookLibrary.DataStoreInfo)o), true, false);
        }

        public void Write11_Thing(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Thing", @"");
                return;
            }
            TopLevelElement();
            Write4_Thing(@"Thing", @"", ((global::NotebookLibrary.Thing)o), true, false);
        }

        public void Write12_LstInstallationMaterial(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LstInstallationMaterial", @"");
                return;
            }
            TopLevelElement();
            Write5_LstInstallationMaterial(@"LstInstallationMaterial", @"", ((global::NotebookLibrary.Models.LstInstallationMaterial)o), true, false);
        }

        public void Write13_Item(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LstInstallationMaterialQualifier", @"");
                return;
            }
            TopLevelElement();
            Write6_Item(@"LstInstallationMaterialQualifier", @"", ((global::NotebookLibrary.Models.LstInstallationMaterialQualifier)o), true, false);
        }

        public void Write14_Site(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"Site", @"");
                return;
            }
            TopLevelElement();
            Write7_Site(@"Site", @"", ((global::NotebookLibrary.Models.Site)o), true, false);
        }

        public void Write15_SiteController(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"SiteController", @"");
                return;
            }
            TopLevelElement();
            Write8_SiteController(@"SiteController", @"", ((global::NotebookLibrary.Controllers.SiteController)o), true, false);
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

        void Write7_Site(string n, string ns, global::NotebookLibrary.Models.Site o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NotebookLibrary.Models.Site)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"Site", @"");
            WriteElementStringRaw(@"Id", @"", System.Xml.XmlConvert.ToString((global::System.Guid)((global::System.Guid)o.@Id)));
            WriteElementString(@"ShortName", @"", ((global::System.String)o.@ShortName));
            WriteElementString(@"FullName", @"", ((global::System.String)o.@FullName));
            WriteElementString(@"PublicationName", @"", ((global::System.String)o.@PublicationName));
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

        public object Read9_XmlHelper() {
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

        public object Read10_DataStoreInfo() {
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

        public object Read11_Thing() {
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

        public object Read12_LstInstallationMaterial() {
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

        public object Read13_Item() {
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

        public object Read14_Site() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id7_Site && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read7_Site(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":Site");
            }
            return (object)o;
        }

        public object Read15_SiteController() {
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

        global::NotebookLibrary.Models.Site Read7_Site(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_Site && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NotebookLibrary.Models.Site o;
            o = new global::NotebookLibrary.Models.Site();
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
            int whileIterations1 = 0;
            int readerCount1 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id9_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@Id = System.Xml.XmlConvert.ToGuid(Reader.ReadElementString());
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id10_ShortName && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@ShortName = Reader.ReadElementString();
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id11_FullName && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@FullName = Reader.ReadElementString();
                            }
                            paramsRead[2] = true;
                            break;
                        }
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id12_PublicationName && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@PublicationName = Reader.ReadElementString();
                            }
                            paramsRead[3] = true;
                            break;
                        }
                        UnknownNode((object)o, @":Id, :ShortName, :FullName, :PublicationName");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @":Id, :ShortName, :FullName, :PublicationName");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations1, ref readerCount1);
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
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id9_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
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
                CheckReaderCount(ref whileIterations2, ref readerCount2);
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
            int whileIterations3 = 0;
            int readerCount3 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id9_Id && (object) Reader.NamespaceURI == (object)id2_Item)) {
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
                CheckReaderCount(ref whileIterations3, ref readerCount3);
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
            int whileIterations5 = 0;
            int readerCount5 = ReaderCount;
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
                CheckReaderCount(ref whileIterations5, ref readerCount5);
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

        protected override void InitCallbacks() {
        }

        string id3_DataStoreInfo;
        string id14_Database;
        string id1_XmlHelper;
        string id11_FullName;
        string id12_PublicationName;
        string id7_Site;
        string id17_ServerPassword;
        string id13_Description;
        string id16_ServerUsername;
        string id15_ServerAddress;
        string id6_Item;
        string id4_Thing;
        string id5_LstInstallationMaterial;
        string id8_SiteController;
        string id2_Item;
        string id9_Id;
        string id10_ShortName;

        protected override void InitIDs() {
            id3_DataStoreInfo = Reader.NameTable.Add(@"DataStoreInfo");
            id14_Database = Reader.NameTable.Add(@"Database");
            id1_XmlHelper = Reader.NameTable.Add(@"XmlHelper");
            id11_FullName = Reader.NameTable.Add(@"FullName");
            id12_PublicationName = Reader.NameTable.Add(@"PublicationName");
            id7_Site = Reader.NameTable.Add(@"Site");
            id17_ServerPassword = Reader.NameTable.Add(@"ServerPassword");
            id13_Description = Reader.NameTable.Add(@"Description");
            id16_ServerUsername = Reader.NameTable.Add(@"ServerUsername");
            id15_ServerAddress = Reader.NameTable.Add(@"ServerAddress");
            id6_Item = Reader.NameTable.Add(@"LstInstallationMaterialQualifier");
            id4_Thing = Reader.NameTable.Add(@"Thing");
            id5_LstInstallationMaterial = Reader.NameTable.Add(@"LstInstallationMaterial");
            id8_SiteController = Reader.NameTable.Add(@"SiteController");
            id2_Item = Reader.NameTable.Add(@"");
            id9_Id = Reader.NameTable.Add(@"Id");
            id10_ShortName = Reader.NameTable.Add(@"ShortName");
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
            ((XmlSerializationWriter1)writer).Write9_XmlHelper(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read9_XmlHelper();
        }
    }

    public sealed class DataStoreInfoSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"DataStoreInfo", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write10_DataStoreInfo(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read10_DataStoreInfo();
        }
    }

    public sealed class ThingSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Thing", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write11_Thing(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read11_Thing();
        }
    }

    public sealed class LstInstallationMaterialSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LstInstallationMaterial", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write12_LstInstallationMaterial(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read12_LstInstallationMaterial();
        }
    }

    public sealed class LstInstallationMaterialQualifierSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LstInstallationMaterialQualifier", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write13_Item(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read13_Item();
        }
    }

    public sealed class SiteSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"Site", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write14_Site(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read14_Site();
        }
    }

    public sealed class SiteControllerSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"SiteController", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write15_SiteController(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read15_SiteController();
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
                    _tmp[@"XmlHelper::"] = @"Read9_XmlHelper";
                    _tmp[@"NotebookLibrary.DataStoreInfo::"] = @"Read10_DataStoreInfo";
                    _tmp[@"NotebookLibrary.Thing::"] = @"Read11_Thing";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterial::"] = @"Read12_LstInstallationMaterial";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterialQualifier::"] = @"Read13_Item";
                    _tmp[@"NotebookLibrary.Models.Site::"] = @"Read14_Site";
                    _tmp[@"NotebookLibrary.Controllers.SiteController::"] = @"Read15_SiteController";
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
                    _tmp[@"XmlHelper::"] = @"Write9_XmlHelper";
                    _tmp[@"NotebookLibrary.DataStoreInfo::"] = @"Write10_DataStoreInfo";
                    _tmp[@"NotebookLibrary.Thing::"] = @"Write11_Thing";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterial::"] = @"Write12_LstInstallationMaterial";
                    _tmp[@"NotebookLibrary.Models.LstInstallationMaterialQualifier::"] = @"Write13_Item";
                    _tmp[@"NotebookLibrary.Models.Site::"] = @"Write14_Site";
                    _tmp[@"NotebookLibrary.Controllers.SiteController::"] = @"Write15_SiteController";
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
                    _tmp.Add(@"NotebookLibrary.Models.Site::", new SiteSerializer());
                    _tmp.Add(@"NotebookLibrary.DataStoreInfo::", new DataStoreInfoSerializer());
                    _tmp.Add(@"NotebookLibrary.Models.LstInstallationMaterial::", new LstInstallationMaterialSerializer());
                    _tmp.Add(@"NotebookLibrary.Thing::", new ThingSerializer());
                    _tmp.Add(@"XmlHelper::", new XmlHelperSerializer());
                    _tmp.Add(@"NotebookLibrary.Controllers.SiteController::", new SiteControllerSerializer());
                    _tmp.Add(@"NotebookLibrary.Models.LstInstallationMaterialQualifier::", new LstInstallationMaterialQualifierSerializer());
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
            if (type == typeof(global::NotebookLibrary.Models.Site)) return true;
            if (type == typeof(global::NotebookLibrary.Controllers.SiteController)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::XmlHelper)) return new XmlHelperSerializer();
            if (type == typeof(global::NotebookLibrary.DataStoreInfo)) return new DataStoreInfoSerializer();
            if (type == typeof(global::NotebookLibrary.Thing)) return new ThingSerializer();
            if (type == typeof(global::NotebookLibrary.Models.LstInstallationMaterial)) return new LstInstallationMaterialSerializer();
            if (type == typeof(global::NotebookLibrary.Models.LstInstallationMaterialQualifier)) return new LstInstallationMaterialQualifierSerializer();
            if (type == typeof(global::NotebookLibrary.Models.Site)) return new SiteSerializer();
            if (type == typeof(global::NotebookLibrary.Controllers.SiteController)) return new SiteControllerSerializer();
            return null;
        }
    }
}
