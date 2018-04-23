using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraTabbedMdi;
using DevExpress.XtraTab;

namespace WindowsApplication1
{
    public class MyMDIManager : XtraTabbedMdiManager
    {

        private XtraMdiTabPage _FixedPage;
        public XtraMdiTabPage FixedPage
        {
            get { return _FixedPage; }
            set 
            { 
                _FixedPage = value;
                InitFixedPage();
            }
        }

        public MyMDIManager()
        {
            BeginFloating += OnBeginFloating;
        }

 

        public void SetFixedForm(Form form)
        {
            form.MdiParent = MdiParent;
            form.Show();
            FixedPage = PageByForm(form);
        }

        private XtraMdiTabPage PageByForm(Form form)
        {
            foreach (XtraMdiTabPage page in Pages)
            {
                if (page.MdiChild == form)
                {
                    return page;
                }
            }
            return null;
        }
        private void InitFixedPage()
        {
            if (_FixedPage != null)
            {
                _FixedPage.ShowCloseButton = DevExpress.Utils.DefaultBoolean.False;
                CheckFixedPage();
            }
        }

        protected override void DoDragDrop()
        {
            if (SelectedPage == FixedPage)
                return;
            base.DoDragDrop();
            CheckFixedPage();
        }

        private void CheckFixedPage()
        {
            if (_FixedPage == null)
                return;
            if (Pages.IndexOf(FixedPage) != 0)
            {
                Pages.Remove(FixedPage);
                Pages.Insert(0, FixedPage);
                LayoutChanged();
            }
        }


        void OnBeginFloating(object sender, FloatingCancelEventArgs e)
        {
            e.Cancel = PageByForm(e.ChildForm) == FixedPage;
        }

    }
}
