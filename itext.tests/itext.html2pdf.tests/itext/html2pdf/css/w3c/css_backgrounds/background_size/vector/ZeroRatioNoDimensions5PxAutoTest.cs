using System;
using iText.Html2pdf.Css.W3c;
using iText.Test.Attributes;

namespace iText.Html2pdf.Css.W3c.Css_backgrounds.Background_size.Vector {
    // TODO DEVSIX-4388 percentage is not supported for rect's x, y, width and height
    [LogMessage(iText.StyledXmlParser.LogMessageConstant.UNKNOWN_ABSOLUTE_METRIC_LENGTH_PARSED, Count = 2)]
    [LogMessage(iText.IO.LogMessageConstant.ATTEMPT_PROCESS_NAN, Count = 8)]
    public class ZeroRatioNoDimensions5PxAutoTest : W3CCssTest {
        protected internal override String GetHtmlFileName() {
            return "zero-ratio-no-dimensions-5px-auto.html";
        }
    }
}
