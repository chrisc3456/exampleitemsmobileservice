namespace Example.Functions
{
    public class Item
    {

        public string Id { get; set; }
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }

        public Item(string _id)
        {
            Id = _id;
            Date = "2020-05-0" + _id + "T12:34:56";
            Title = "Lorem ipsum dolor sit amet, consectetur adipiscing elit";
            Excerpt = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam id molestie augue, in molestie turpis. Fusce elit ipsum, volutpat vitae justo at, sodales aliquam risus. Donec tristique mollis venenatis. Phasellus.";
            Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc in eros at lacus sagittis mollis in ultricies elit. Curabitur vulputate dui in mi semper maximus sed non tellus. Sed eu imperdiet tortor. Mauris id erat vitae mauris tincidunt porttitor. Etiam pulvinar sed est id fringilla. Vestibulum nec eros sed odio faucibus volutpat. Integer dapibus nibh justo, ut venenatis tortor tincidunt ut. Sed non ante consequat, convallis ante a, porttitor nunc. Nulla accumsan eu urna quis tristique." +
                        "\r\n\r\n" +
                        "Morbi tempus ac libero et suscipit. Sed porta in ipsum nec mattis. Vestibulum et commodo nunc. In vehicula, sem vel sagittis ornare, lacus dui congue augue, eget feugiat tellus elit quis ante. Integer id elit sit amet nisi auctor pulvinar. Etiam et urna volutpat elit ultricies porta at placerat dui. Ut mattis tortor mauris, sed consectetur lacus facilisis id. Duis fermentum porta quam, ut rutrum odio tristique at." +
                        "\r\n\r\n" +
                        "Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Class aptent taciti sociosqu ad litora torquent per conubia nostra, per inceptos himenaeos. Pellentesque iaculis purus sed feugiat tincidunt. Aenean in tincidunt nulla. Ut velit metus, tempus ut velit vitae, dictum vehicula metus. Ut sed tempor enim. Nam porta, velit et cursus mollis, felis mi imperdiet sapien, at blandit metus urna scelerisque sapien. Quisque a nibh in velit pulvinar euismod. Fusce consequat ex eu enim suscipit congue. Donec eu magna nec massa varius luctus. Integer tempus nibh nec tortor finibus ullamcorper. Morbi efficitur elit leo, et bibendum metus pretium vel. Proin scelerisque tortor a elit venenatis, vestibulum consequat leo iaculis. Nullam non lacus feugiat, pharetra lacus euismod, viverra nulla.";
        }
    }
}