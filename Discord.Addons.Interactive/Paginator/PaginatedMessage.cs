using System.Collections.Generic;

namespace Discord.Addons.Interactive
{
    public class PaginatedMessage
    {
		public IEnumerable<EmbedFieldBuilder> FirstColumns { get; set; }
		public IEnumerable<EmbedFieldBuilder> SecondColumns { get; set; }

        public string Content { get; set; } = "";

        public EmbedAuthorBuilder Author { get; set; } = null;
        public Color Color { get; set; } = Color.Default;
        public string Title { get; set; } = "";

        public PaginatedAppearanceOptions Options { get; set; } = PaginatedAppearanceOptions.Default;
    }
}
