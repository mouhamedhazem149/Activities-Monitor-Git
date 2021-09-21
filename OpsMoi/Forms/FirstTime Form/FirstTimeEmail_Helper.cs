namespace OpsMoi.Forms.FirstTime_Form
{
    public static class FirstTimeEmail_Helper
    {
        public static string GetBody(string client_name, string client_serial, string client_address, string client_phonenumber, string client_email, string user_password, string FacebookLink) => 
			Body.Replace("{client_name}", client_name).Replace("{client_serial}", client_serial).Replace("{client_address}", client_address).Replace("{client_phonenumber}", client_phonenumber).Replace("{client_email}", client_email).Replace("{user_name}", client_name).Replace("{user_password}", user_password).Replace("{facebooklink}", FacebookLink);

        private static string Body => @"<!DOCTYPE html PUBLIC ""-//W3C//DTD XHTML 1.0 Transitional //EN"" ""http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd"">

<html xmlns=""http://www.w3.org/1999/xhtml"" xmlns:o=""urn:schemas-microsoft-com:office:office"" xmlns:v=""urn:schemas-microsoft-com:vml"">
<head>
<!--[if gte mso 9]><xml><o:OfficeDocumentSettings><o:AllowPNG/><o:PixelsPerInch>96</o:PixelsPerInch></o:OfficeDocumentSettings></xml><![endif]-->
<meta content=""text/html; charset=utf-8"" http-equiv=""Content-Type""/>
<meta content=""width=device-width"" name=""viewport""/>
<!--[if !mso]><!-->
<meta content=""IE=edge"" http-equiv=""X-UA-Compatible""/>
<!--<![endif]-->
<title></title>
<!--[if !mso]><!-->
<!--<![endif]-->
<style type=""text/css"">
		body {
			margin: 0;
			padding: 0;
		}

		table,
		td,
		tr {
			vertical-align: top;
			border-collapse: collapse;
		}

		* {
			line-height: inherit;
		}

		a[x-apple-data-detectors=true] {
			color: inherit !important;
			text-decoration: none !important;
		}
	</style>
<style id=""media-query"" type=""text/css"">
		@media (max-width: 720px) {

			.block-grid,
			.col {
				min-width: 320px !important;
				max-width: 100% !important;
				display: block !important;
			}

			.block-grid {
				width: 100% !important;
			}

			.col {
				width: 100% !important;
			}

			.col>div {
				margin: 0 auto;
			}

			img.fullwidth,
			img.fullwidthOnMobile {
				max-width: 100% !important;
			}

			.no-stack .col {
				min-width: 0 !important;
				display: table-cell !important;
			}

			.no-stack.two-up .col {
				width: 50% !important;
			}

			.no-stack .col.num2 {
				width: 16.6% !important;
			}

			.no-stack .col.num3 {
				width: 25% !important;
			}

			.no-stack .col.num4 {
				width: 33% !important;
			}

			.no-stack .col.num5 {
				width: 41.6% !important;
			}

			.no-stack .col.num6 {
				width: 50% !important;
			}

			.no-stack .col.num7 {
				width: 58.3% !important;
			}

			.no-stack .col.num8 {
				width: 66.6% !important;
			}

			.no-stack .col.num9 {
				width: 75% !important;
			}

			.no-stack .col.num10 {
				width: 83.3% !important;
			}

			.video-block {
				max-width: none !important;
			}

			.mobile_hide {
				min-height: 0px;
				max-height: 0px;
				max-width: 0px;
				display: none;
				overflow: hidden;
				font-size: 0px;
			}

			.desktop_hide {
				display: block !important;
				max-height: none !important;
			}
		}
	</style>
</head>
<body class=""clean-body"" style=""margin: 0; padding: 0; -webkit-text-size-adjust: 100%; background-color: #f9f9f9;"">
<!--[if IE]><div class=""ie-browser""><![endif]-->
<table bgcolor=""#f9f9f9"" cellpadding=""0"" cellspacing=""0"" class=""nl-container"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; min-width: 320px; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; background-color: #f9f9f9; width: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td style=""word-break: break-word; vertical-align: top;"" valign=""top"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td align=""center"" style=""background-color:#f9f9f9""><![endif]-->
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: transparent;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:transparent;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:5px; padding-bottom:5px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:5px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 5px; padding-right: 5px; padding-bottom: 5px; padding-left: 5px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" height=""0"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 0px solid transparent; height: 0px; width: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td height=""0"" style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: transparent;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:transparent;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:5px; padding-bottom:5px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:5px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<div align=""center"" class=""img-container center autowidth"" style=""padding-right: 0px;padding-left: 0px;"">
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr style=""line-height:0px""><td style=""padding-right: 0px;padding-left: 0px;"" align=""center""><![endif]--><img align=""center"" alt=""Alternate text"" border=""0"" class=""center autowidth"" src=""cid:LogoImage_ContentID"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: 0; width: 100%; max-width: 200px; display: block;"" title=""Alternate text"" width=""200""/>
<!--[if mso]></td></tr></table><![endif]-->
</div>
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: transparent;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:transparent;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:5px; padding-bottom:5px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:5px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 5px; padding-right: 5px; padding-bottom: 5px; padding-left: 5px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" height=""5"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 0px solid transparent; height: 5px; width: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td height=""5"" style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: transparent;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:transparent;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:5px; padding-bottom:0px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:5px; padding-bottom:0px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<div align=""center"" class=""img-container center autowidth"" style=""padding-right: 0px;padding-left: 0px;"">
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr style=""line-height:0px""><td style=""padding-right: 0px;padding-left: 0px;"" align=""center""><![endif]--><img align=""center"" alt=""Alternate text"" border=""0"" class=""center autowidth"" src=""cid:UpPinkImage_ContentID"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: 0; width: 100%; max-width: 700px; display: block;"" title=""Alternate text"" width=""700""/>
<!--[if mso]></td></tr></table><![endif]-->
</div>
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: #ffd3e0;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:#ffd3e0;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:#ffd3e0""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:#ffd3e0;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:0px; padding-bottom:0px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:0px; padding-bottom:0px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" height=""10"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 0px solid transparent; height: 10px; width: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td height=""10"" style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<div align=""center"" class=""img-container center fixedwidth"" style=""padding-right: 0px;padding-left: 0px;"">
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr style=""line-height:0px""><td style=""padding-right: 0px;padding-left: 0px;"" align=""center""><![endif]--><img align=""center"" alt=""I'm an image"" border=""0"" class=""center fixedwidth"" src=""cid:WelcomeImage_ContentID"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: 0; width: 100%; max-width: 420px; display: block;"" title=""I'm an image"" width=""420""/>
<!--[if mso]></td></tr></table><![endif]-->
</div>
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 40px; padding-left: 40px; padding-top: 10px; padding-bottom: 10px; font-family: Tahoma, sans-serif""><![endif]-->
<div style=""color:#191919;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;line-height:1.5;padding-top:10px;padding-right:40px;padding-bottom:10px;padding-left:40px;"">
<div style=""line-height: 1.5; font-size: 12px; color: #191919; font-family: Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif; mso-line-height-alt: 18px;"">
<p style=""font-size: 16px; line-height: 1.5; text-align: center; word-break: break-word; mso-line-height-alt: 24px; margin: 0;""><strong><span style=""font-size: 38px;"">مرحبا {client_name}<br/></span></strong></p>
<p style=""font-size: 16px; line-height: 1.5; text-align: center; word-break: break-word; mso-line-height-alt: 24px; margin: 0;""><strong><span style=""font-size: 38px;"">في برنامج المذكرة الخاص<br/></span></strong></p>
</div>
</div>
<!--[if mso]></td></tr></table><![endif]-->
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 10px; padding-left: 10px; padding-top: 10px; padding-bottom: 10px; font-family: Tahoma, sans-serif""><![endif]-->
<div style=""color:#191919;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;line-height:1.2;padding-top:10px;padding-right:10px;padding-bottom:10px;padding-left:10px;"">
<div style=""line-height: 1.2; font-size: 12px; color: #191919; font-family: Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif; mso-line-height-alt: 14px;"">
<p style=""text-align: center; line-height: 1.2; word-break: break-word; font-size: 16px; mso-line-height-alt: 19px; margin: 0;""><span style=""font-size: 16px;""><strong>شكرا للاشتراك في البرنامج</strong></span></p>
</div>
</div>
<!--[if mso]></td></tr></table><![endif]-->
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" height=""35"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 0px solid transparent; height: 35px; width: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td height=""35"" style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: #ffffff;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:#ffffff;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:#ffffff""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:#ffffff;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:0px; padding-bottom:5px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:0px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" height=""5"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 0px solid transparent; height: 5px; width: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td height=""5"" style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 20px; padding-left: 20px; padding-top: 10px; padding-bottom: 0px; font-family: Tahoma, sans-serif""><![endif]-->
<div style=""color:#191919;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;line-height:1.5;padding-top:10px;padding-right:20px;padding-bottom:0px;padding-left:20px;"">
<div style=""line-height: 1.5; font-size: 12px; color: #191919; font-family: Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif; mso-line-height-alt: 18px;"">
<p style=""font-size: 28px; line-height: 1.5; text-align: center; word-break: break-word; mso-line-height-alt: 42px; margin: 0;""><span style=""font-size: 28px;""><strong><span style="""">تم تسجيل العميل : {client_name} بسيريال {client_serial} بنجاح<br/></span></strong></span></p>
</div>
</div>
<!--[if mso]></td></tr></table><![endif]-->
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 5px; padding-right: 5px; padding-bottom: 5px; padding-left: 5px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 2px solid #FFD3E0; width: 15%;"" valign=""top"" width=""15%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 0px; padding-right: 0px; padding-bottom: 0px; padding-left: 0px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 2px solid #FFD3E0; width: 5%;"" valign=""top"" width=""5%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: #ffffff;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:#ffffff;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:#ffffff""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:#ffffff;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:0px; padding-bottom:5px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:0px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" height=""0"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 0px solid transparent; height: 0px; width: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td height=""0"" style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 10px; padding-left: 10px; padding-top: 10px; padding-bottom: 10px; font-family: Tahoma, sans-serif""><![endif]-->
<div style=""color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;line-height:1.2;padding-top:10px;padding-right:10px;padding-bottom:10px;padding-left:10px;"">
<div style=""line-height: 1.2; font-size: 12px; color: #555555; font-family: Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif; mso-line-height-alt: 14px;"">
<p style=""font-size: 15px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 18px; margin: 0;""><span style=""font-size: 15px;"">اسم العميل المسجل : {client_name} </span></p>
<p style=""font-size: 15px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 18px; margin: 0;""><span style=""font-size: 15px;"">رقم الموبايل : {client_phonenumber}</span></p>
<p style=""font-size: 15px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 18px; margin: 0;""><span style=""font-size: 15px;"">العنوان : {client_address}</span></p>
<p style=""font-size: 15px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 18px; margin: 0;""><span style=""font-size: 15px;"">البريد الألكتروني : {client_email}</span></p>
<p style=""font-size: 15px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 18px; margin: 0;""><span style=""font-size: 15px;"">السيريال الخاص بالبرنامج : {client_serial}</span></p>
<p style=""font-size: 15px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 18px; margin: 0;""><span style=""font-size: 15px;"">-----------------------------------------------------</span></p>
<p style=""font-size: 14px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 17px; margin: 0;""> </p>
<p style=""font-size: 15px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 18px; margin: 0;""><span style=""font-size: 15px;"">اسم مستخدم البرنامج : {user_name}</span></p>
<p style=""font-size: 15px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 18px; margin: 0;""><span style=""font-size: 15px;"">كلمة المرور الخاصة بالمستخدم : {user_password}</span></p>
<p style=""font-size: 15px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 18px; margin: 0;""><span style=""font-size: 15px;"">------------------------------------------------------</span></p>
<p style=""font-size: 14px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 17px; margin: 0;""> </p>
<p style=""font-size: 15px; line-height: 1.2; word-break: break-word; text-align: right; mso-line-height-alt: 18px; margin: 0;""><span style=""font-size: 15px;"">برجاء الاحتفاظ بهذه البيانات في حالة الحاجة لها لاحقا</span></p>
</div>
</div>
<!--[if mso]></td></tr></table><![endif]-->
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: transparent;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:transparent;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:0px; padding-bottom:5px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:0px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 10px; padding-left: 10px; padding-top: 10px; padding-bottom: 10px; font-family: Tahoma, sans-serif""><![endif]-->
<div style=""color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;line-height:1.2;padding-top:10px;padding-right:10px;padding-bottom:10px;padding-left:10px;"">
<div style=""line-height: 1.2; font-size: 12px; color: #555555; font-family: Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif; mso-line-height-alt: 14px;"">
<p style=""font-size: 22px; line-height: 1.2; word-break: break-word; text-align: center; mso-line-height-alt: 26px; margin: 0;""><span style=""font-size: 22px;"">شكرا للاشتراك في البرنامج</span></p>
</div>
</div>
<!--[if mso]></td></tr></table><![endif]-->
<div align=""center"" class=""img-container center autowidth"" style=""padding-right: 0px;padding-left: 0px;"">
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr style=""line-height:0px""><td style=""padding-right: 0px;padding-left: 0px;"" align=""center""><![endif]--><img align=""center"" alt=""Alternate text"" border=""0"" class=""center autowidth"" src=""cid:WhiteDownImage_ContentID"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: 0; width: 100%; max-width: 700px; display: block;"" title=""Alternate text"" width=""700""/>
<!--[if mso]></td></tr></table><![endif]-->
</div>
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: transparent;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:transparent;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:5px; padding-bottom:5px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:5px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 5px; padding-right: 5px; padding-bottom: 5px; padding-left: 5px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" height=""10"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 0px solid transparent; height: 10px; width: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td height=""10"" style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: #ffffff;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:#ffffff;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:#ffffff""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:#ffffff;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:0px; padding-bottom:5px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:0px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" height=""20"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 0px solid transparent; height: 20px; width: 95%;"" valign=""top"" width=""95%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td height=""20"" style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table cellpadding=""0"" cellspacing=""0"" class=""social_icons"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td style=""word-break: break-word; vertical-align: top; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
<table align=""center"" cellpadding=""0"" cellspacing=""0"" class=""social_table"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-tspace: 0; mso-table-rspace: 0; mso-table-bspace: 0; mso-table-lspace: 0;"" valign=""top"">
<tbody>
<tr align=""center"" style=""vertical-align: top; display: inline-block; text-align: center;"" valign=""top"">
<td style=""word-break: break-word; vertical-align: top; padding-bottom: 0; padding-right: 7.5px; padding-left: 7.5px;"" valign=""top""><a href=""{facebooklink}"" target=""_blank""><img alt=""Facebook"" height=""32"" src=""cid:FacebookImage_ContentID"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: 0; display: block;"" title=""Facebook"" width=""32""/></a></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" height=""5"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 0px solid transparent; height: 5px; width: 95%;"" valign=""top"" width=""95%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td height=""5"" style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 40px; padding-left: 40px; padding-top: 0px; padding-bottom: 10px; font-family: Tahoma, sans-serif""><![endif]-->
<div style=""color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;line-height:2;padding-top:0px;padding-right:40px;padding-bottom:10px;padding-left:40px;"">
<div style=""line-height: 2; font-size: 12px; color: #555555; font-family: Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif; mso-line-height-alt: 24px;"">
<p style=""font-size: 14px; line-height: 2; word-break: break-word; text-align: center; mso-line-height-alt: 28px; margin: 0;"">في حالة وجود أي استفسارات قم بارسال رسالة علي البريد الالكتروني : user@doamin.com</p>
<p style=""font-size: 14px; line-height: 2; word-break: break-word; text-align: center; mso-line-height-alt: 28px; margin: 0;"">يكمنك أيضا التواصل معنا علي رقم : 011111111111</p>
</div>
</div>
<!--[if mso]></td></tr></table><![endif]-->
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: transparent;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:transparent;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:0px; padding-bottom:5px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:0px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 10px; padding-left: 10px; padding-top: 10px; padding-bottom: 10px; font-family: Tahoma, sans-serif""><![endif]-->
<div style=""color:#555555;font-family:Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif;line-height:1.2;padding-top:10px;padding-right:10px;padding-bottom:10px;padding-left:10px;"">
<div style=""line-height: 1.2; font-size: 12px; color: #555555; font-family: Montserrat, Trebuchet MS, Lucida Grande, Lucida Sans Unicode, Lucida Sans, Tahoma, sans-serif; mso-line-height-alt: 14px;"">
<p style=""font-size: 14px; line-height: 1.2; word-break: break-word; text-align: center; mso-line-height-alt: 17px; margin: 0;"">Eissa Corp,2020 . All rights reserved.</p>
</div>
</div>
<!--[if mso]></td></tr></table><![endif]-->
<div align=""center"" class=""img-container center autowidth"" style=""padding-right: 0px;padding-left: 0px;"">
<!--[if mso]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr style=""line-height:0px""><td style=""padding-right: 0px;padding-left: 0px;"" align=""center""><![endif]--><img align=""center"" alt=""Alternate text"" border=""0"" class=""center autowidth"" src=""cid:WhiteDownImage_ContentID"" style=""text-decoration: none; -ms-interpolation-mode: bicubic; height: auto; border: 0; width: 100%; max-width: 700px; display: block;"" title=""Alternate text"" width=""700""/>
<!--[if mso]></td></tr></table><![endif]-->
</div>
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<div style=""background-color:transparent;overflow:hidden"">
<div class=""block-grid"" style=""min-width: 320px; max-width: 700px; overflow-wrap: break-word; word-wrap: break-word; word-break: break-word; Margin: 0 auto; width: 100%; background-color: transparent;"">
<div style=""border-collapse: collapse;display: table;width: 100%;background-color:transparent;"">
<!--[if (mso)|(IE)]><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0"" style=""background-color:transparent;""><tr><td align=""center""><table cellpadding=""0"" cellspacing=""0"" border=""0"" style=""width:700px""><tr class=""layout-full-width"" style=""background-color:transparent""><![endif]-->
<!--[if (mso)|(IE)]><td align=""center"" width=""700"" style=""background-color:transparent;width:700px; border-top: 0px solid transparent; border-left: 0px solid transparent; border-bottom: 0px solid transparent; border-right: 0px solid transparent;"" valign=""top""><table width=""100%"" cellpadding=""0"" cellspacing=""0"" border=""0""><tr><td style=""padding-right: 0px; padding-left: 0px; padding-top:5px; padding-bottom:5px;""><![endif]-->
<div class=""col num12"" style=""min-width: 320px; max-width: 700px; display: table-cell; vertical-align: top; width: 700px;"">
<div style=""width:100% !important;"">
<!--[if (!mso)&(!IE)]><!-->
<div style=""border-top:0px solid transparent; border-left:0px solid transparent; border-bottom:0px solid transparent; border-right:0px solid transparent; padding-top:5px; padding-bottom:5px; padding-right: 0px; padding-left: 0px;"">
<!--<![endif]-->
<table border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td class=""divider_inner"" style=""word-break: break-word; vertical-align: top; min-width: 100%; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%; padding-top: 10px; padding-right: 10px; padding-bottom: 10px; padding-left: 10px;"" valign=""top"">
<table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" class=""divider_content"" height=""5"" role=""presentation"" style=""table-layout: fixed; vertical-align: top; border-spacing: 0; border-collapse: collapse; mso-table-lspace: 0pt; mso-table-rspace: 0pt; border-top: 0px solid transparent; height: 5px; width: 100%;"" valign=""top"" width=""100%"">
<tbody>
<tr style=""vertical-align: top;"" valign=""top"">
<td height=""5"" style=""word-break: break-word; vertical-align: top; -ms-text-size-adjust: 100%; -webkit-text-size-adjust: 100%;"" valign=""top""><span></span></td>
</tr>
</tbody>
</table>
</td>
</tr>
</tbody>
</table>
<!--[if (!mso)&(!IE)]><!-->
</div>
<!--<![endif]-->
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
<!--[if (mso)|(IE)]></td></tr></table></td></tr></table><![endif]-->
</div>
</div>
</div>
<!--[if (mso)|(IE)]></td></tr></table><![endif]-->
</td>
</tr>
</tbody>
</table>
<!--[if (IE)]></div><![endif]-->
</body>
</html>";
    }
}
