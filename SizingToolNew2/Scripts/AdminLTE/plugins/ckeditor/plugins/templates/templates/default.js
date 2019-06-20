/*
 Copyright (c) 2003-2019, CKSource - Frederico Knabben. All rights reserved.
 For licensing, see LICENSE.md or https://ckeditor.com/legal/ckeditor-oss-license
*/
CKEDITOR.addTemplates("default",
    {
        imagesPath: CKEDITOR.getUrl(CKEDITOR.plugins.getPath("templates") + "templates/images/"),

        templates:

            [
                {
                    title: "Image and Title",
                    image: "template1.gif",
                    description: "One main image with a title and text that surround the image.",

                    html: '\x3ch3\x3e\x3cimg src\x3d" " alt\x3d"" style\x3d"margin-right: 10px" height\x3d"100" width\x3d"100" align\x3d"left" /\x3eType the title here\x3c/h3\x3e\x3cp\x3eType the text here\x3c/p\x3e'
                },

                {
                    title: "Strange Template",
                    image: "template2.gif",
                    description: "A template that defines two columns, each one with a title, and some text.",

              
         
                      html: '<div style="width: 80%">'+
                        
                        '<h3>' +
                            'Title goes here' +

                        'Support is 8x5, with provision for response to Sev1 issues.' +
                        'Assumes standard vendor solution including internet connectivity is available for the SEPM consoles.' +
                        'Assumes customer has the correct level of vendor support(Symantec Business Critical Support  or higher).Top tier vendor support is stipulated in the Endpoint Security service description.' +
                        'Assumes the contract or any associated documents of understanding do not stipulate SLAs beyond those indicated in the Endpoint Security service description.' +
                        'Assumes no customized reports; only reports as currently delivered by the Endpoint Security team.' +
                        'Assumes standard responsibility matrix wherein the  Endpoint Security team does not manage software delivery or break-fix of endpoints.The  Endpoint Security team is responsible for the AV infrastructure, Tier 3 support of malware issues, participation in security efforts around malware, etc.Server teams would be responsible for server endpoint product break-fix, imaging teams or software delivery teams would handle software delivery, Unix team would handle NAS filer issues, etc.' +
                        'Assumes IBM  Endpoint Security team have exclusive administrative control over the management console and does not share this control with the customer or 3rd party.' +

                        '</h3>'+

                        '<table style="width:150px;float: right" cellspacing="0" cellpadding="0" border="1">' +
                        '<caption style="border:solid 1px black">' +
                        '<strong>Table title</strong>' +
                        '</caption>' +
                        '<tr>' +
                        '<td>&nbsp;</td> ' +
                        '<td>&nbsp;</td>' +
                        '<td>&nbsp;</td>' +
                        '</tr>' +
                        '<tr>' +
                        '<td>&nbsp;</td>' +
                        '<td>&nbsp;</td>' +
                        '<td>&nbsp;</td>' +
                        '</tr>' +
                        '<tr>' +
                        '<td>&nbsp;</td>' +
                        '<td>&nbsp;</td>' +
                        '<td>&nbsp;</td>' +
                        '</tr>' +
                        '</table>' +
                        '<p>' +
                        'Type the text here' +
                        '</p>' +
                        '</div>' 
                },
                                           
                                 
                {
                    title: "Text and Table",
                    image: "template3.gif",
                    description: "A title with some text and a table.",

                    html: '<div style="width: 80%">' +

                        '<h3>'+
                        '<u>'+ 
                        '<span style="color:#000000"> <span style="font-size:16px">Assumption for this Sizing:</span>'+
                        '</span>'+
                        '</u>'+
                        '</h3>'+

                        '<h3>&nbsp;</h3>'+


                        '<ul >' +

                        '<li>'+
                        '<h3>Support is 8x5, with provision for response to Sev1 issues.</h3>' +
                        '</li>' +
                        '<li>' +
                        '<h3>Assumes standard vendor solution including internet connectivity is available for the SEPM consoles.</h3>'+
                        '</li>' +
                        '<li>' +
                        '<h3>Assumes customer has the correct level of vendor support(Symantec Business Critical Support or higher).Top tier vendor support is stipulated in the Endpoint Securityservice description.</h3>' +
                        '</li>' +
                        '<li>' +
                            '<h3>Assumes the contract or any associated documents of understanding do not stipulate SLAs beyond those indicated in the Endpoint Security service description.</h3>' +
                        '</li>' +
                        '<li>' +
                        '<h3>Assumes no customized reports; only reports ascurrently delivered by the Endpoint Security team.</h3>' +
                        '</li>'+
                            '<li>' +
                            '<h3>Assumes standard responsibility matrix wherein the EndpointSecurity team does not manage software delivery or break-fix of endpoints.The Endpoint Security team isresponsible for the AV infrastructure, Tier 3 support of malware issues, participation in security efforts around malware, etc.Server teams would be responsible for server endpoint product break-fix, imaging teams or software delivery teams would handle software delivery, Unix team would handle NAS filer issues, etc.</h3>'+
                            '</li>' +
                        '<li>' +
                        '<h3>Assumes IBM Endpoint Security team have exclusive administrative control over the management console and does not share this control with the customer or 3rd party.</h3>' +
                        '</li>'+
                    '</ul>'
                }
            ]
    });