///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace IOC_POC_Ranorex
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the IOC_POC_RanorexRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("f98c6c43-3031-4928-b8df-9e860408dece")]
    public partial class IOC_POC_RanorexRepository : RepoGenBaseFolder
    {
        static IOC_POC_RanorexRepository instance = new IOC_POC_RanorexRepository();
        IOC_POC_RanorexRepositoryFolders.ApplicationUnderTestAppFolder _applicationundertest;
        IOC_POC_RanorexRepositoryFolders.NewTabWorkMicrosoftEdgeAppFolder _newtabworkmicrosoftedge;
        IOC_POC_RanorexRepositoryFolders.FrpaezIOCPOCRanorexAppFolder _frpaeziocpocranorex;
        IOC_POC_RanorexRepositoryFolders.KatalonShopKatalonEcommerceWorkAppFolder _katalonshopkatalonecommercework;
        IOC_POC_RanorexRepositoryFolders.MyAccountKatalonShopAnd1MorePageAppFolder _myaccountkatalonshopand1morepage;

        /// <summary>
        /// Gets the singleton class instance representing the IOC_POC_RanorexRepository element repository.
        /// </summary>
        [RepositoryFolder("f98c6c43-3031-4928-b8df-9e860408dece")]
        public static IOC_POC_RanorexRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public IOC_POC_RanorexRepository() 
            : base("IOC_POC_RanorexRepository", "/", null, 0, false, "f98c6c43-3031-4928-b8df-9e860408dece", ".\\RepositoryImages\\IOC_POC_RanorexRepositoryf98c6c43.rximgres")
        {
            _applicationundertest = new IOC_POC_RanorexRepositoryFolders.ApplicationUnderTestAppFolder(this);
            _newtabworkmicrosoftedge = new IOC_POC_RanorexRepositoryFolders.NewTabWorkMicrosoftEdgeAppFolder(this);
            _frpaeziocpocranorex = new IOC_POC_RanorexRepositoryFolders.FrpaezIOCPOCRanorexAppFolder(this);
            _katalonshopkatalonecommercework = new IOC_POC_RanorexRepositoryFolders.KatalonShopKatalonEcommerceWorkAppFolder(this);
            _myaccountkatalonshopand1morepage = new IOC_POC_RanorexRepositoryFolders.MyAccountKatalonShopAnd1MorePageAppFolder(this);
        }

#region Variables

        string _webPageAccount = "Blank";

        /// <summary>
        /// Gets or sets the value of variable webPageAccount.
        /// </summary>
        [TestVariable("bcc52106-83d1-4a60-b82f-38d042c1d878")]
        public string webPageAccount
        {
            get { return _webPageAccount; }
            set { _webPageAccount = value; }
        }

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("f98c6c43-3031-4928-b8df-9e860408dece")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The ApplicationUnderTest folder.
        /// </summary>
        [RepositoryFolder("ffe7712e-9506-4076-87f4-3e232e3457f0")]
        public virtual IOC_POC_RanorexRepositoryFolders.ApplicationUnderTestAppFolder ApplicationUnderTest
        {
            get { return _applicationundertest; }
        }

        /// <summary>
        /// The NewTabWorkMicrosoftEdge folder.
        /// </summary>
        [RepositoryFolder("2fbbb4e3-7ab7-4a84-be9a-0a2b637c10f8")]
        public virtual IOC_POC_RanorexRepositoryFolders.NewTabWorkMicrosoftEdgeAppFolder NewTabWorkMicrosoftEdge
        {
            get { return _newtabworkmicrosoftedge; }
        }

        /// <summary>
        /// The FrpaezIOCPOCRanorex folder.
        /// </summary>
        [RepositoryFolder("55299283-bf94-42af-9021-29f460c2f2e3")]
        public virtual IOC_POC_RanorexRepositoryFolders.FrpaezIOCPOCRanorexAppFolder FrpaezIOCPOCRanorex
        {
            get { return _frpaeziocpocranorex; }
        }

        /// <summary>
        /// The KatalonShopKatalonEcommerceWork folder.
        /// </summary>
        [RepositoryFolder("c631ec6c-55fb-4bc1-a9a7-8b5c2ba38bea")]
        public virtual IOC_POC_RanorexRepositoryFolders.KatalonShopKatalonEcommerceWorkAppFolder KatalonShopKatalonEcommerceWork
        {
            get { return _katalonshopkatalonecommercework; }
        }

        /// <summary>
        /// The MyAccountKatalonShopAnd1MorePage folder.
        /// </summary>
        [RepositoryFolder("a24d6970-326f-43a7-b949-b944910b9f21")]
        public virtual IOC_POC_RanorexRepositoryFolders.MyAccountKatalonShopAnd1MorePageAppFolder MyAccountKatalonShopAnd1MorePage
        {
            get { return _myaccountkatalonshopand1morepage; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class IOC_POC_RanorexRepositoryFolders
    {
        /// <summary>
        /// The ApplicationUnderTestAppFolder folder.
        /// </summary>
        [RepositoryFolder("ffe7712e-9506-4076-87f4-3e232e3457f0")]
        public partial class ApplicationUnderTestAppFolder : RepoGenBaseFolder
        {

            /// <summary>
            /// Creates a new ApplicationUnderTest  folder.
            /// </summary>
            public ApplicationUnderTestAppFolder(RepoGenBaseFolder parentFolder) :
                    base("ApplicationUnderTest", "/dom[@domain='www.ranorex.com']", parentFolder, 30000, null, false, "ffe7712e-9506-4076-87f4-3e232e3457f0", "")
            {
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("ffe7712e-9506-4076-87f4-3e232e3457f0")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("ffe7712e-9506-4076-87f4-3e232e3457f0")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }
        }

        /// <summary>
        /// The NewTabWorkMicrosoftEdgeAppFolder folder.
        /// </summary>
        [RepositoryFolder("2fbbb4e3-7ab7-4a84-be9a-0a2b637c10f8")]
        public partial class NewTabWorkMicrosoftEdgeAppFolder : RepoGenBaseFolder
        {
            IOC_POC_RanorexRepositoryFolders.MicrosoftEdgeFolder _microsoftedge;
            RepoItemInfo _view1021Info;

            /// <summary>
            /// Creates a new NewTabWorkMicrosoftEdge  folder.
            /// </summary>
            public NewTabWorkMicrosoftEdgeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("NewTabWorkMicrosoftEdge", "/form[@title>'New tab - Work - Microsoft​']", parentFolder, 30000, null, true, "2fbbb4e3-7ab7-4a84-be9a-0a2b637c10f8", "")
            {
                _microsoftedge = new IOC_POC_RanorexRepositoryFolders.MicrosoftEdgeFolder(this);
                _view1021Info = new RepoItemInfo(this, "View1021", "container[@name>'Katalon Shop – Katalon Ecommerce']/container[@name='Microsoft Edge']//toolbar[@automationid='view_1000']/?/?/text[@automationid='view_1021']", ".//text[@automationid='view_1021']", 30000, null, "37c647ee-715a-4675-89ef-b62d986d7acf");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("2fbbb4e3-7ab7-4a84-be9a-0a2b637c10f8")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("2fbbb4e3-7ab7-4a84-be9a-0a2b637c10f8")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The View1021 item.
            /// </summary>
            [RepositoryItem("37c647ee-715a-4675-89ef-b62d986d7acf")]
            public virtual Ranorex.Text View1021
            {
                get
                {
                    return _view1021Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The View1021 item info.
            /// </summary>
            [RepositoryItemInfo("37c647ee-715a-4675-89ef-b62d986d7acf")]
            public virtual RepoItemInfo View1021Info
            {
                get
                {
                    return _view1021Info;
                }
            }

            /// <summary>
            /// The MicrosoftEdge folder.
            /// </summary>
            [RepositoryFolder("643bd48b-5f13-438c-8c03-dfa7a80812a1")]
            public virtual IOC_POC_RanorexRepositoryFolders.MicrosoftEdgeFolder MicrosoftEdge
            {
                get { return _microsoftedge; }
            }
        }

        /// <summary>
        /// The MicrosoftEdgeFolder folder.
        /// </summary>
        [RepositoryFolder("643bd48b-5f13-438c-8c03-dfa7a80812a1")]
        public partial class MicrosoftEdgeFolder : RepoGenBaseFolder
        {
            RepoItemInfo _nativeviewhostInfo;
            RepoItemInfo _framegrabhandleInfo;
            RepoItemInfo _view10211Info;

            /// <summary>
            /// Creates a new MicrosoftEdge  folder.
            /// </summary>
            public MicrosoftEdgeFolder(RepoGenBaseFolder parentFolder) :
                    base("MicrosoftEdge", "container[@name='New tab - Microsoft Edge']/container[@name='Microsoft Edge']", parentFolder, 30000, null, false, "643bd48b-5f13-438c-8c03-dfa7a80812a1", "")
            {
                _nativeviewhostInfo = new RepoItemInfo(this, "NativeViewHost", ".//container[@classname='SidebarContentsSplitView']//text[@automationid='view_1053']/container[@classname='NativeViewHost']", "container[@classname='NativeViewHost']", 30000, null, "f80b3dad-e712-47f1-b387-022640345f5c");
                _framegrabhandleInfo = new RepoItemInfo(this, "FrameGrabHandle", ".//tabpagelist[@classname='TabStripRegionView']/container[@classname='FrameGrabHandle']", "", 30000, null, "17ebfa64-0a42-4c83-bb8a-2f692105cf17");
                _view10211Info = new RepoItemInfo(this, "View10211", ".//toolbar[@automationid='view_1000']/?/?/text[@automationid='view_1021']", "", 30000, null, "e8bd4d14-8423-4eaa-8b86-57e92ec9d679");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("643bd48b-5f13-438c-8c03-dfa7a80812a1")]
            public virtual Ranorex.Container Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("643bd48b-5f13-438c-8c03-dfa7a80812a1")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The NativeViewHost item.
            /// </summary>
            [RepositoryItem("f80b3dad-e712-47f1-b387-022640345f5c")]
            public virtual Ranorex.Container NativeViewHost
            {
                get
                {
                    return _nativeviewhostInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The NativeViewHost item info.
            /// </summary>
            [RepositoryItemInfo("f80b3dad-e712-47f1-b387-022640345f5c")]
            public virtual RepoItemInfo NativeViewHostInfo
            {
                get
                {
                    return _nativeviewhostInfo;
                }
            }

            /// <summary>
            /// The FrameGrabHandle item.
            /// </summary>
            [RepositoryItem("17ebfa64-0a42-4c83-bb8a-2f692105cf17")]
            public virtual Ranorex.Container FrameGrabHandle
            {
                get
                {
                    return _framegrabhandleInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The FrameGrabHandle item info.
            /// </summary>
            [RepositoryItemInfo("17ebfa64-0a42-4c83-bb8a-2f692105cf17")]
            public virtual RepoItemInfo FrameGrabHandleInfo
            {
                get
                {
                    return _framegrabhandleInfo;
                }
            }

            /// <summary>
            /// The View10211 item.
            /// </summary>
            [RepositoryItem("e8bd4d14-8423-4eaa-8b86-57e92ec9d679")]
            public virtual Ranorex.Text View10211
            {
                get
                {
                    return _view10211Info.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The View10211 item info.
            /// </summary>
            [RepositoryItemInfo("e8bd4d14-8423-4eaa-8b86-57e92ec9d679")]
            public virtual RepoItemInfo View10211Info
            {
                get
                {
                    return _view10211Info;
                }
            }
        }

        /// <summary>
        /// The FrpaezIOCPOCRanorexAppFolder folder.
        /// </summary>
        [RepositoryFolder("55299283-bf94-42af-9021-29f460c2f2e3")]
        public partial class FrpaezIOCPOCRanorexAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _summarytagcodeInfo;

            /// <summary>
            /// Creates a new FrpaezIOCPOCRanorex  folder.
            /// </summary>
            public FrpaezIOCPOCRanorexAppFolder(RepoGenBaseFolder parentFolder) :
                    base("FrpaezIOCPOCRanorex", "/dom[@domain='github.com']", parentFolder, 30000, null, false, "55299283-bf94-42af-9021-29f460c2f2e3", "")
            {
                _summarytagcodeInfo = new RepoItemInfo(this, "SummaryTagCode", ".//div[#'repo-content-pjax-container']/div/div/div[3]/div[1]/div[2]/span//summary[@innertext='    Code']", ".//div[#'repo-content-pjax-container']//summary[@innertext='    Code']", 30000, null, "a4e09dee-a591-4317-a399-d4ebd6e2877d");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("55299283-bf94-42af-9021-29f460c2f2e3")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("55299283-bf94-42af-9021-29f460c2f2e3")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The SummaryTagCode item.
            /// </summary>
            [RepositoryItem("a4e09dee-a591-4317-a399-d4ebd6e2877d")]
            public virtual Ranorex.SummaryTag SummaryTagCode
            {
                get
                {
                    return _summarytagcodeInfo.CreateAdapter<Ranorex.SummaryTag>(true);
                }
            }

            /// <summary>
            /// The SummaryTagCode item info.
            /// </summary>
            [RepositoryItemInfo("a4e09dee-a591-4317-a399-d4ebd6e2877d")]
            public virtual RepoItemInfo SummaryTagCodeInfo
            {
                get
                {
                    return _summarytagcodeInfo;
                }
            }
        }

        /// <summary>
        /// The KatalonShopKatalonEcommerceWorkAppFolder folder.
        /// </summary>
        [RepositoryFolder("c631ec6c-55fb-4bc1-a9a7-8b5c2ba38bea")]
        public partial class KatalonShopKatalonEcommerceWorkAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _nativeviewhostInfo;
            RepoItemInfo _nativeviewhost1Info;

            /// <summary>
            /// Creates a new KatalonShopKatalonEcommerceWork  folder.
            /// </summary>
            public KatalonShopKatalonEcommerceWorkAppFolder(RepoGenBaseFolder parentFolder) :
                    base("KatalonShopKatalonEcommerceWork", "/form[@title>'Katalon Shop – Katalon Ecommerce']", parentFolder, 30000, null, true, "c631ec6c-55fb-4bc1-a9a7-8b5c2ba38bea", "")
            {
                _nativeviewhostInfo = new RepoItemInfo(this, "NativeViewHost", "container[@name>'Katalon Shop – Katalon Ecommerce']/container[@name='Microsoft Edge']//container[@classname='SidebarContentsSplitView']//text[@automationid='view_1053']/container[@classname='NativeViewHost']", ".//text[@automationid='view_1053']/container[@classname='NativeViewHost']", 30000, null, "9448bb6f-4d4e-4203-b259-3895897c22f0");
                _nativeviewhost1Info = new RepoItemInfo(this, "NativeViewHost1", "container[@name>'My account – Katalon Shop']/container[@name='Microsoft Edge']//container[@classname='SidebarContentsSplitView']//text[@automationid='view_1053']/container[@classname='NativeViewHost']", ".//text[@automationid='view_1053']/container[@classname='NativeViewHost']", 30000, null, "7aad74b6-96b7-4b43-ae05-99e010eb5276");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("c631ec6c-55fb-4bc1-a9a7-8b5c2ba38bea")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("c631ec6c-55fb-4bc1-a9a7-8b5c2ba38bea")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The NativeViewHost item.
            /// </summary>
            [RepositoryItem("9448bb6f-4d4e-4203-b259-3895897c22f0")]
            public virtual Ranorex.Container NativeViewHost
            {
                get
                {
                    return _nativeviewhostInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The NativeViewHost item info.
            /// </summary>
            [RepositoryItemInfo("9448bb6f-4d4e-4203-b259-3895897c22f0")]
            public virtual RepoItemInfo NativeViewHostInfo
            {
                get
                {
                    return _nativeviewhostInfo;
                }
            }

            /// <summary>
            /// The NativeViewHost1 item.
            /// </summary>
            [RepositoryItem("7aad74b6-96b7-4b43-ae05-99e010eb5276")]
            public virtual Ranorex.Container NativeViewHost1
            {
                get
                {
                    return _nativeviewhost1Info.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The NativeViewHost1 item info.
            /// </summary>
            [RepositoryItemInfo("7aad74b6-96b7-4b43-ae05-99e010eb5276")]
            public virtual RepoItemInfo NativeViewHost1Info
            {
                get
                {
                    return _nativeviewhost1Info;
                }
            }
        }

        /// <summary>
        /// The MyAccountKatalonShopAnd1MorePageAppFolder folder.
        /// </summary>
        [RepositoryFolder("a24d6970-326f-43a7-b949-b944910b9f21")]
        public partial class MyAccountKatalonShopAnd1MorePageAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _nativeviewhostInfo;
            RepoItemInfo _view7Info;

            /// <summary>
            /// Creates a new MyAccountKatalonShopAnd1MorePage  folder.
            /// </summary>
            public MyAccountKatalonShopAnd1MorePageAppFolder(RepoGenBaseFolder parentFolder) :
                    base("MyAccountKatalonShopAnd1MorePage", "/form[@title>'My account – Katalon Shop']", parentFolder, 30000, null, true, "a24d6970-326f-43a7-b949-b944910b9f21", "")
            {
                _nativeviewhostInfo = new RepoItemInfo(this, "NativeViewHost", "container[@name>'My account – Katalon Shop']/container[@name='Microsoft Edge']//container[@classname='SidebarContentsSplitView']//text[@automationid='view_1053']/container[@classname='NativeViewHost']", ".//text[@automationid='view_1053']/container[@classname='NativeViewHost']", 30000, null, "20077d52-8502-4e76-8e23-702768d4fd00");
                _view7Info = new RepoItemInfo(this, "View7", "container[@name>'My account – Katalon Shop']/container[@name='Microsoft Edge']//button[@automationid='view_7']", ".//button[@automationid='view_7']", 30000, null, "cad23a5a-bc92-4c3c-9a9a-95fcd50cabde");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("a24d6970-326f-43a7-b949-b944910b9f21")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("a24d6970-326f-43a7-b949-b944910b9f21")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The NativeViewHost item.
            /// </summary>
            [RepositoryItem("20077d52-8502-4e76-8e23-702768d4fd00")]
            public virtual Ranorex.Container NativeViewHost
            {
                get
                {
                    return _nativeviewhostInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The NativeViewHost item info.
            /// </summary>
            [RepositoryItemInfo("20077d52-8502-4e76-8e23-702768d4fd00")]
            public virtual RepoItemInfo NativeViewHostInfo
            {
                get
                {
                    return _nativeviewhostInfo;
                }
            }

            /// <summary>
            /// The View7 item.
            /// </summary>
            [RepositoryItem("cad23a5a-bc92-4c3c-9a9a-95fcd50cabde")]
            public virtual Ranorex.Button View7
            {
                get
                {
                    return _view7Info.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The View7 item info.
            /// </summary>
            [RepositoryItemInfo("cad23a5a-bc92-4c3c-9a9a-95fcd50cabde")]
            public virtual RepoItemInfo View7Info
            {
                get
                {
                    return _view7Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
