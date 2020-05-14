using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Agility.Web;
using Agility.Web.Objects;

namespace Website.Models
{
    public partial class AgilityCodeTemplate : Agility.Web.AgilityContentItem
    {
        private string __title = null;
        private bool __title_set = false;
        public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
        private string __textblob = null;
        private bool __textblob_set = false;
        public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
        private string __referencename = null;
        private bool __referencename_set = false;
        public virtual string ReferenceName { get { if (!__referencename_set) __referencename = GetFieldValue<string>("ReferenceName"); __referencename_set = true; return __referencename; } set { __referencename = value; __referencename_set = true; } }
        private bool __visible;
        private bool __visible_set = false;
        public virtual bool Visible { get { if (!__visible_set) __visible = GetFieldValue<bool>("Visible"); __visible_set = true; return __visible; } set { __visible = value; __visible_set = true; } }

    }
    public partial class AgilityCSS : Agility.Web.AgilityContentItem
    {
        private string __title = null;
        private bool __title_set = false;
        public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
        private string __textblob = null;
        private bool __textblob_set = false;
        public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
        private string __referencename = null;
        private bool __referencename_set = false;
        public virtual string ReferenceName { get { if (!__referencename_set) __referencename = GetFieldValue<string>("ReferenceName"); __referencename_set = true; return __referencename; } set { __referencename = value; __referencename_set = true; } }
        private bool __minify;
        private bool __minify_set = false;
        public virtual bool Minify { get { if (!__minify_set) __minify = GetFieldValue<bool>("Minify"); __minify_set = true; return __minify; } set { __minify = value; __minify_set = true; } }

    }
    public partial class AgilityJavascript : Agility.Web.AgilityContentItem
    {
        private string __title = null;
        private bool __title_set = false;
        public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
        private string __textblob = null;
        private bool __textblob_set = false;
        public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }
        private string __referencename = null;
        private bool __referencename_set = false;
        public virtual string ReferenceName { get { if (!__referencename_set) __referencename = GetFieldValue<string>("ReferenceName"); __referencename_set = true; return __referencename; } set { __referencename = value; __referencename_set = true; } }
        private bool __minify;
        private bool __minify_set = false;
        public virtual bool Minify { get { if (!__minify_set) __minify = GetFieldValue<bool>("Minify"); __minify_set = true; return __minify; } set { __minify = value; __minify_set = true; } }

    }
    public partial class FeaturedContentItem : Agility.Web.AgilityContentItem
    {
        private string __title = null;
        private bool __title_set = false;
        public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
        private string __summary = null;
        private bool __summary_set = false;
        public virtual string Summary { get { if (!__summary_set) __summary = GetFieldValue<string>("Summary"); __summary_set = true; return __summary; } set { __summary = value; __summary_set = true; } }
        private string __viewdetailslabel = null;
        private bool __viewdetailslabel_set = false;
        public virtual string ViewDetailsLabel { get { if (!__viewdetailslabel_set) __viewdetailslabel = GetFieldValue<string>("ViewDetailsLabel"); __viewdetailslabel_set = true; return __viewdetailslabel; } set { __viewdetailslabel = value; __viewdetailslabel_set = true; } }
        private string __viewdetailsurl = null;
        private bool __viewdetailsurl_set = false;
        public virtual string ViewDetailsURL { get { if (!__viewdetailsurl_set) __viewdetailsurl = GetFieldValue<string>("ViewDetailsURL"); __viewdetailsurl_set = true; return __viewdetailsurl; } set { __viewdetailsurl = value; __viewdetailsurl_set = true; } }

    }
    public partial class GlobalFooter : Agility.Web.AgilityContentItem
    {
        private string __html = null;
        private bool __html_set = false;
        public virtual string HTML { get { if (!__html_set) __html = GetFieldValue<string>("HTML"); __html_set = true; return __html; } set { __html = value; __html_set = true; } }

    }
    public partial class GlobalHeader : Agility.Web.AgilityContentItem
    {
        private string __sitename = null;
        private bool __sitename_set = false;
        public virtual string SiteName { get { if (!__sitename_set) __sitename = GetFieldValue<string>("SiteName"); __sitename_set = true; return __sitename; } set { __sitename = value; __sitename_set = true; } }
        private Attachment __sitelogo = null;
        public virtual Attachment SiteLogo { get { if (__sitelogo == null) __sitelogo = GetAttachment("SiteLogo"); return __sitelogo; } set { __sitelogo = value; } }

    }
    public partial class Product : Agility.Web.AgilityContentItem
    {
        private string __title = null;
        private bool __title_set = false;
        public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
        private IAgilityContentRepository<ProductCategory> __productcategory = null;
        public virtual IAgilityContentRepository<ProductCategory> ProductCategory { get { if (__productcategory == null) __productcategory = GetLinkedContent<ProductCategory>("ProductCategory"); return __productcategory; } set { __productcategory = value; } }
        private int __productcategoryid;
        private bool __productcategoryid_set = false;
        public virtual int ProductCategoryID { get { if (!__productcategoryid_set) __productcategoryid = GetFieldValue<int>("ProductCategoryID"); __productcategoryid_set = true; return __productcategoryid; } set { __productcategoryid = value; __productcategoryid_set = true; } }
        private string __productcategorytitle = null;
        private bool __productcategorytitle_set = false;
        public virtual string ProductCategoryTitle { get { if (!__productcategorytitle_set) __productcategorytitle = GetFieldValue<string>("ProductCategoryTitle"); __productcategorytitle_set = true; return __productcategorytitle; } set { __productcategorytitle = value; __productcategorytitle_set = true; } }
        private double __price;
        private bool __price_set = false;
        public virtual double Price { get { if (!__price_set) __price = GetFieldValue<double>("Price"); __price_set = true; return __price; } set { __price = value; __price_set = true; } }
        private string __summary = null;
        private bool __summary_set = false;
        public virtual string Summary { get { if (!__summary_set) __summary = GetFieldValue<string>("Summary"); __summary_set = true; return __summary; } set { __summary = value; __summary_set = true; } }
        private string __details = null;
        private bool __details_set = false;
        public virtual string Details { get { if (!__details_set) __details = GetFieldValue<string>("Details"); __details_set = true; return __details; } set { __details = value; __details_set = true; } }
        private Attachment __listingimage = null;
        public virtual Attachment ListingImage { get { if (__listingimage == null) __listingimage = GetAttachment("ListingImage"); return __listingimage; } set { __listingimage = value; } }
        private Attachment __mainimage = null;
        public virtual Attachment MainImage { get { if (__mainimage == null) __mainimage = GetAttachment("MainImage"); return __mainimage; } set { __mainimage = value; } }

    }
    public partial class ProductCategory : Agility.Web.AgilityContentItem
    {
        private string __title = null;
        private bool __title_set = false;
        public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }

    }
    public partial class Module_FeaturedContent : Agility.Web.AgilityContentItem
    {
        private IAgilityContentRepository<FeaturedContentItem> __featuredcontent = null;
        public virtual IAgilityContentRepository<FeaturedContentItem> FeaturedContent { get { if (__featuredcontent == null) __featuredcontent = GetLinkedContent<FeaturedContentItem>("FeaturedContent", "", "itemOrder ", ""); return __featuredcontent; } set { __featuredcontent = value; } }
        private string __featuredcontentsortids = null;
        private bool __featuredcontentsortids_set = false;
        public virtual string FeaturedContentSortIDs { get { if (!__featuredcontentsortids_set) __featuredcontentsortids = GetFieldValue<string>("FeaturedContentSortIDs"); __featuredcontentsortids_set = true; return __featuredcontentsortids; } set { __featuredcontentsortids = value; __featuredcontentsortids_set = true; } }

    }
    public partial class Module_FormBuilder : Agility.Web.AgilityContentItem
    {
        private string __recordtypename = null;
        private bool __recordtypename_set = false;
        public virtual string RecordTypeName { get { if (!__recordtypename_set) __recordtypename = GetFieldValue<string>("RecordTypeName"); __recordtypename_set = true; return __recordtypename; } set { __recordtypename = value; __recordtypename_set = true; } }
        private string __responsetype = null;
        private bool __responsetype_set = false;
        public virtual string ResponseType { get { if (!__responsetype_set) __responsetype = GetFieldValue<string>("ResponseType"); __responsetype_set = true; return __responsetype; } set { __responsetype = value; __responsetype_set = true; } }
        private string __thankyoutemplate = null;
        private bool __thankyoutemplate_set = false;
        public virtual string ThankYouTemplate { get { if (!__thankyoutemplate_set) __thankyoutemplate = GetFieldValue<string>("ThankYouTemplate"); __thankyoutemplate_set = true; return __thankyoutemplate; } set { __thankyoutemplate = value; __thankyoutemplate_set = true; } }
        private string __redirecturl = null;
        private bool __redirecturl_set = false;
        public virtual string RedirectURL { get { if (!__redirecturl_set) __redirecturl = GetFieldValue<string>("RedirectURL"); __redirecturl_set = true; return __redirecturl; } set { __redirecturl = value; __redirecturl_set = true; } }
        private bool __includecaptcha;
        private bool __includecaptcha_set = false;
        public virtual bool IncludeCaptcha { get { if (!__includecaptcha_set) __includecaptcha = GetFieldValue<bool>("IncludeCaptcha"); __includecaptcha_set = true; return __includecaptcha; } set { __includecaptcha = value; __includecaptcha_set = true; } }
        private string __errortemplate = null;
        private bool __errortemplate_set = false;
        public virtual string ErrorTemplate { get { if (!__errortemplate_set) __errortemplate = GetFieldValue<string>("ErrorTemplate"); __errortemplate_set = true; return __errortemplate; } set { __errortemplate = value; __errortemplate_set = true; } }
        private bool __submitasemail;
        private bool __submitasemail_set = false;
        public virtual bool SubmitasEmail { get { if (!__submitasemail_set) __submitasemail = GetFieldValue<bool>("SubmitasEmail"); __submitasemail_set = true; return __submitasemail; } set { __submitasemail = value; __submitasemail_set = true; } }
        private string __emailsendto = null;
        private bool __emailsendto_set = false;
        public virtual string EmailSendTo { get { if (!__emailsendto_set) __emailsendto = GetFieldValue<string>("EmailSendTo"); __emailsendto_set = true; return __emailsendto; } set { __emailsendto = value; __emailsendto_set = true; } }
        private string __emailfrom = null;
        private bool __emailfrom_set = false;
        public virtual string EmailFrom { get { if (!__emailfrom_set) __emailfrom = GetFieldValue<string>("EmailFrom"); __emailfrom_set = true; return __emailfrom; } set { __emailfrom = value; __emailfrom_set = true; } }
        private string __emailsubjecttemplate = null;
        private bool __emailsubjecttemplate_set = false;
        public virtual string EmailSubjectTemplate { get { if (!__emailsubjecttemplate_set) __emailsubjecttemplate = GetFieldValue<string>("EmailSubjectTemplate"); __emailsubjecttemplate_set = true; return __emailsubjecttemplate; } set { __emailsubjecttemplate = value; __emailsubjecttemplate_set = true; } }
        private string __emailbodytemplate = null;
        private bool __emailbodytemplate_set = false;
        public virtual string EmailBodyTemplate { get { if (!__emailbodytemplate_set) __emailbodytemplate = GetFieldValue<string>("EmailBodyTemplate"); __emailbodytemplate_set = true; return __emailbodytemplate; } set { __emailbodytemplate = value; __emailbodytemplate_set = true; } }
        private bool __customizeform;
        private bool __customizeform_set = false;
        public virtual bool CustomizeForm { get { if (!__customizeform_set) __customizeform = GetFieldValue<bool>("CustomizeForm"); __customizeform_set = true; return __customizeform; } set { __customizeform = value; __customizeform_set = true; } }
        private string __submissionform = null;
        private bool __submissionform_set = false;
        public virtual string SubmissionForm { get { if (!__submissionform_set) __submissionform = GetFieldValue<string>("SubmissionForm"); __submissionform_set = true; return __submissionform; } set { __submissionform = value; __submissionform_set = true; } }
        private bool __submitintougc;
        private bool __submitintougc_set = false;
        public virtual bool SubmitIntoUGC { get { if (!__submitintougc_set) __submitintougc = GetFieldValue<bool>("SubmitIntoUGC"); __submitintougc_set = true; return __submitintougc; } set { __submitintougc = value; __submitintougc_set = true; } }

    }
    public partial class Module_ImageGallery : Agility.Web.AgilityContentItem
    {
        private Gallery __imagegallery = null;
        private bool __imagegallery_set = false;
        public virtual Gallery ImageGallery { get { if (!__imagegallery_set) __imagegallery = GetFieldValue<Gallery>("ImageGallery"); __imagegallery_set = true; return __imagegallery; } set { __imagegallery = value; __imagegallery_set = true; } }

    }
    public partial class Module_Jumbotron : Agility.Web.AgilityContentItem
    {
        private string __title = null;
        private bool __title_set = false;
        public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
        private string __summary = null;
        private bool __summary_set = false;
        public virtual string Summary { get { if (!__summary_set) __summary = GetFieldValue<string>("Summary"); __summary_set = true; return __summary; } set { __summary = value; __summary_set = true; } }
        private string __learnmorelabel = null;
        private bool __learnmorelabel_set = false;
        public virtual string LearnMoreLabel { get { if (!__learnmorelabel_set) __learnmorelabel = GetFieldValue<string>("LearnMoreLabel"); __learnmorelabel_set = true; return __learnmorelabel; } set { __learnmorelabel = value; __learnmorelabel_set = true; } }
        private string __learnmoreurl = null;
        private bool __learnmoreurl_set = false;
        public virtual string LearnMoreURL { get { if (!__learnmoreurl_set) __learnmoreurl = GetFieldValue<string>("LearnMoreURL"); __learnmoreurl_set = true; return __learnmoreurl; } set { __learnmoreurl = value; __learnmoreurl_set = true; } }

    }
    public partial class Module_NewsletterSignupModal : Agility.Web.AgilityContentItem
    {
        private bool __openonload;
        private bool __openonload_set = false;
        public virtual bool OpenOnLoad { get { if (!__openonload_set) __openonload = GetFieldValue<bool>("OpenOnLoad"); __openonload_set = true; return __openonload; } set { __openonload = value; __openonload_set = true; } }
        private Attachment __image = null;
        public virtual Attachment Image { get { if (__image == null) __image = GetAttachment("Image"); return __image; } set { __image = value; } }
        private string __html = null;
        private bool __html_set = false;
        public virtual string HTML { get { if (!__html_set) __html = GetFieldValue<string>("HTML"); __html_set = true; return __html; } set { __html = value; __html_set = true; } }
        private string __formtitle = null;
        private bool __formtitle_set = false;
        public virtual string FormTitle { get { if (!__formtitle_set) __formtitle = GetFieldValue<string>("FormTitle"); __formtitle_set = true; return __formtitle; } set { __formtitle = value; __formtitle_set = true; } }
        private string __formdescription = null;
        private bool __formdescription_set = false;
        public virtual string FormDescription { get { if (!__formdescription_set) __formdescription = GetFieldValue<string>("FormDescription"); __formdescription_set = true; return __formdescription; } set { __formdescription = value; __formdescription_set = true; } }
        private string __firstnamelabel = null;
        private bool __firstnamelabel_set = false;
        public virtual string FirstNameLabel { get { if (!__firstnamelabel_set) __firstnamelabel = GetFieldValue<string>("FirstNameLabel"); __firstnamelabel_set = true; return __firstnamelabel; } set { __firstnamelabel = value; __firstnamelabel_set = true; } }
        private string __lastnamelabel = null;
        private bool __lastnamelabel_set = false;
        public virtual string LastNameLabel { get { if (!__lastnamelabel_set) __lastnamelabel = GetFieldValue<string>("LastNameLabel"); __lastnamelabel_set = true; return __lastnamelabel; } set { __lastnamelabel = value; __lastnamelabel_set = true; } }
        private string __emailaddresslabel = null;
        private bool __emailaddresslabel_set = false;
        public virtual string EmailAddressLabel { get { if (!__emailaddresslabel_set) __emailaddresslabel = GetFieldValue<string>("EmailAddressLabel"); __emailaddresslabel_set = true; return __emailaddresslabel; } set { __emailaddresslabel = value; __emailaddresslabel_set = true; } }
        private string __submitlabel = null;
        private bool __submitlabel_set = false;
        public virtual string SubmitLabel { get { if (!__submitlabel_set) __submitlabel = GetFieldValue<string>("SubmitLabel"); __submitlabel_set = true; return __submitlabel; } set { __submitlabel = value; __submitlabel_set = true; } }
        private string __requiredfieldvalidation = null;
        private bool __requiredfieldvalidation_set = false;
        public virtual string RequiredFieldValidation { get { if (!__requiredfieldvalidation_set) __requiredfieldvalidation = GetFieldValue<string>("RequiredFieldValidation"); __requiredfieldvalidation_set = true; return __requiredfieldvalidation; } set { __requiredfieldvalidation = value; __requiredfieldvalidation_set = true; } }
        private string __formdisclaimer = null;
        private bool __formdisclaimer_set = false;
        public virtual string FormDisclaimer { get { if (!__formdisclaimer_set) __formdisclaimer = GetFieldValue<string>("FormDisclaimer"); __formdisclaimer_set = true; return __formdisclaimer; } set { __formdisclaimer = value; __formdisclaimer_set = true; } }
        private string __successmessage = null;
        private bool __successmessage_set = false;
        public virtual string SuccessMessage { get { if (!__successmessage_set) __successmessage = GetFieldValue<string>("SuccessMessage"); __successmessage_set = true; return __successmessage; } set { __successmessage = value; __successmessage_set = true; } }

    }
    public partial class Module_ProductDetails : Agility.Web.AgilityContentItem
    {

    }
    public partial class Module_ProductListing : Agility.Web.AgilityContentItem
    {
        private string __title = null;
        private bool __title_set = false;
        public virtual string Title { get { if (!__title_set) __title = GetFieldValue<string>("Title"); __title_set = true; return __title; } set { __title = value; __title_set = true; } }
        private IAgilityContentRepository<Product> __products = null;
        public virtual IAgilityContentRepository<Product> Products { get { if (__products == null) __products = GetLinkedContent<Product>("Products"); return __products; } set { __products = value; } }
        private int __productsperpage;
        private bool __productsperpage_set = false;
        public virtual int ProductsPerPage { get { if (!__productsperpage_set) __productsperpage = GetFieldValue<int>("ProductsPerPage"); __productsperpage_set = true; return __productsperpage; } set { __productsperpage = value; __productsperpage_set = true; } }
        private string __viewproductlabel = null;
        private bool __viewproductlabel_set = false;
        public virtual string ViewProductLabel { get { if (!__viewproductlabel_set) __viewproductlabel = GetFieldValue<string>("ViewProductLabel"); __viewproductlabel_set = true; return __viewproductlabel; } set { __viewproductlabel = value; __viewproductlabel_set = true; } }
        private string __filterviewlabel = null;
        private bool __filterviewlabel_set = false;
        public virtual string FilterViewLabel { get { if (!__filterviewlabel_set) __filterviewlabel = GetFieldValue<string>("FilterViewLabel"); __filterviewlabel_set = true; return __filterviewlabel; } set { __filterviewlabel = value; __filterviewlabel_set = true; } }
        private string __filtercategorieslabel = null;
        private bool __filtercategorieslabel_set = false;
        public virtual string FilterCategoriesLabel { get { if (!__filtercategorieslabel_set) __filtercategorieslabel = GetFieldValue<string>("FilterCategoriesLabel"); __filtercategorieslabel_set = true; return __filtercategorieslabel; } set { __filtercategorieslabel = value; __filtercategorieslabel_set = true; } }
        private string __filtercategoriesalllabel = null;
        private bool __filtercategoriesalllabel_set = false;
        public virtual string FilterCategoriesAllLabel { get { if (!__filtercategoriesalllabel_set) __filtercategoriesalllabel = GetFieldValue<string>("FilterCategoriesAllLabel"); __filtercategoriesalllabel_set = true; return __filtercategoriesalllabel; } set { __filtercategoriesalllabel = value; __filtercategoriesalllabel_set = true; } }

    }
    public partial class Module_RichTextArea : Agility.Web.AgilityContentItem
    {
        private string __textblob = null;
        private bool __textblob_set = false;
        public virtual string TextBlob { get { if (!__textblob_set) __textblob = GetFieldValue<string>("TextBlob"); __textblob_set = true; return __textblob; } set { __textblob = value; __textblob_set = true; } }

    }

}

