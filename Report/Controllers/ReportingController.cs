using DevExpress.AspNetCore.Reporting.WebDocumentViewer.Native.Services;
using DevExpress.AspNetCore.Reporting.WebDocumentViewer;
using Microsoft.AspNetCore.Mvc;
namespace OneSPMSh.Controllers 
{ 

public class CustomWebDocumentViewerController : WebDocumentViewerController
{

public CustomWebDocumentViewerController(IWebDocumentViewerMvcControllerService controllerService)
: base(controllerService)
{}
}}