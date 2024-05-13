class Scripture
    {
        private Reference _reference;
        private List<Word> _words;

        public Scripture(string book, int chapter, int verse, string text)
        {
            _reference = new Reference(book, chapter, verse);
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();
            for (int i = 0; i < numberToHide; i++)
            {
                int index = random.Next(_words.Count);
                _words[index].Hide();
            }
        }

        public string GetDisplayText()
        {
            return $"{_reference.GetDisplayText()}: {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden());
        }
    }