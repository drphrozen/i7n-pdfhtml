using System;
using iText.Html2pdf.Css.W3c;

namespace iText.Html2pdf.Css.W3c.Css_backgrounds.Background_attachment_local {
    // TODO DEVSIX-4399 box value is not supported for background
    public class AttachmentLocalClippingColor1RefTest : W3CCssTest {
        protected internal override String GetHtmlFileName() {
            return "attachment-local-clipping-color-1-ref.html";
        }
    }
}
