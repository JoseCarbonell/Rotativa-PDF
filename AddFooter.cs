    // Defining the Footer to PDF..
                string customSwitches = string.Format("--footer-html {0} ", "<URL of you HTML>");
                return new ViewAsPdf("PDF", <Array, String, Any>)
                {
                    PageSize = Rotativa.Options.Size.Letter,
                    PageMargins = { Bottom = 3, Left = 3, Right = 3, Top = 4 },
                    CustomSwitches = customSwitches
                };
