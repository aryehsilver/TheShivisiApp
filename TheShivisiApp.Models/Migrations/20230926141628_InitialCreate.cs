using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheShivisiApp.Models.Migrations;

public partial class InitialCreate : Migration {
  protected override void Up(MigrationBuilder migrationBuilder) {
    migrationBuilder.CreateTable(
        name: "Quotes",
        columns: table => new {
          Id = table.Column<int>(type: "INTEGER", nullable: false)
                .Annotation("Sqlite:Autoincrement", true),
          QuotedText = table.Column<string>(type: "TEXT", nullable: false),
          Source = table.Column<string>(type: "TEXT", nullable: false)
        },
        constraints: table => {
          table.PrimaryKey("PK_Quotes", x => x.Id);
        });

    migrationBuilder.CreateTable(
        name: "Settings",
        columns: table => new {
          Id = table.Column<int>(type: "INTEGER", nullable: false)
                .Annotation("Sqlite:Autoincrement", true),
          RunOnStartUp = table.Column<bool>(type: "INTEGER", nullable: false),
          ShowSplashScreen = table.Column<bool>(type: "INTEGER", nullable: false),
          UseRandomQuote = table.Column<bool>(type: "INTEGER", nullable: false),
          Interval = table.Column<int>(type: "INTEGER", nullable: false),
          NotifText = table.Column<string>(type: "TEXT", nullable: false),
          LastUpdated = table.Column<DateTime>(type: "TEXT", nullable: false)
        },
        constraints: table => {
          table.PrimaryKey("PK_Settings", x => x.Id);
        });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 1, "We should accustom ourselves to express gratitude for the benefits we have enjoyed, thanking and praising Hashem to the best of our ability.", "Rambam, Hilchot Berachot 10:26" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 2, "Klal Yisrael are more beloved than the angels, since the angels do not praise Hashem in Heaven until we praise Him in this world below.", "Chullin 91b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 3, "When we sing songs of praise to Hashem, our sins are forgiven.", "Midrash Tehillim 18" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 4, "Our mouth was created in order to thank Hashem and praise Him.", "Magen Avraham O.C. 60:2" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 5, "A person who lives with a constant awareness of Hashem’s guiding hand will have a life of unrestricted happiness.", "Emunah U'bitachon 1:9" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 6, "We are obligated to focus on and continuously remember Hashem’s constant kindness.", "Kad Hakemach, Purim" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 7, "Everything that happens to us is all miracles; there is no such thing as nature.", "Ramban, Shemot 13:16" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 8, "Observing all the benefits we receive from Hashem will inspire us to serve Him.", "Mesilat Yesharim 8" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 9, "One who knows how to praise Hashem, increases blessings in the upper and lower realms. He is beloved on high, esteemed below and Hashem takes pride in him.", "Zohar vol. 1 p. 59b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 10, "The first rule in serving Hashem is to thank Him - that is the basis of everything.", "Ohr Avigdor Shaar HaBechinah" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 11, "There is no individual in Klal Yisrael for whom hidden miracles do not occur each day.", "Rabbeinu Bechaya, Shemot 30:12" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 12, "Even though Hashem has thousands and myriads of angels who praise Him, He only desires the praises of Klal Yisrael.", "Midrash Mishlei 14:28" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 13, "With every breath that we breathe, we should praise Hashem.", "Bereishit Rabbah 14:11" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 14, "The Jewish nation are not called Reuvenim or Shimonim, rather Yehudim (from the word to thank, since this is our essence).", "Bereishit Rabbah 98:6" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 15, "When we praise Hashem with a pleasant voice and intent, we merit to enter Gan Eden.", "Ohr Zarua, Shabbat 42:7" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 16, "Appreciation enhances our joy of life. Without it, one goes through life like a person in a drunken state, not feeling the pleasure and enjoyment of their many blessings.", "Kuzari 3:16" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 17, "When Klal Yisrael speak about the wonders and awesome phenomena of Hashem… the angels praise Him for having such a precious nation.", "Zohar vol. 2 p. 40b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 18, "Mankind was created to praise and to thank Hashem as well as to serve and fear Him. Those who do so are upholding the world.", "Shitah Mikubetzet, Berachot 6b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 19, "Were it not for Klal Yisrael’s songs and praises to Hashem, the world would not have been created.", "Midrash Otiyot DeRabbi Akiva 1" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 20, "Through song and praises to Hashem we can open the gates of Heaven. When these gates are open, we can request whatever we need.", "Tiferet Shlomo, Ki Tisa" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 21, "When we thank Hashem for all the good that we receive, it is considered as if we brought a korban todah. Consequently, we and the entire world will receive more kindnesses.", "Shomer Emunim, Maamar Hashgacha Pratit 23" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 22, "Rabbi Yehoshua Ben Levi said, anyone who sings praises to Hashem in this world will merit to sing praises to Him in the world to come.", "Sanhedrin 91b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 23, "Each Jew should strive to remember the kindnesses that Hashem does for him on a constant basis.", "Sefer Charedim 9:23" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 24, "If gratitude ceased to exist, how would the world carry on?", "Akeidat Yitzchak, Ki Tisa 181" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 25, "When we thank Hashem for a miracle that He has done for us, we will be saved from other misfortunes.", "Midrash Tehillim 70" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 26, "We should contemplate all the kindnesses that Hashem has done for us from the moment we were born.", "Sefer Hayashar 14" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 27, "Every day we should strive to thank Hashem for more of His Kindnesses and Wisdom.", "Chovot Halevovot, Shaar HaBechinah 6" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 28, "It is our obligation to praise and thank Hashem for His Unlimited Goodness.", "Chovot Halevavot, hakdama to Shaar Avodat Elokim" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 29, "Remembering Hashem’s kindnesses and contemplating them is a mitzvah from the Torah.", "Shaarei Teshuvah 3:17" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 30, "All our existence in this world is for one reason - to thank Hashem.", "Alei Shur vol. 2 p. 283" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 31, "Every praise with which Klal Yisroel extolls Hashem causes the Shechinah to dwell amongst them.", "Midrash Tehillim 18" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 32, "When a Jew rejoices over Hashem’s kindnesses and thanks Him for all the good that He constantly does, he will be saved from sinning and bad occurrences.", "Torat Avot p. 170" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 33, "Hashem longs for the prayers of Klal Yisrael, and their praises are beloved to Him more than anything else.", "Talmud Yerushalmi quoted in Tosafot Succah 53a" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 34, "It is appropriate for us to set a fixed time for thanking Hashem.", "Peleh Yoetz, Hillul" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 35, "A berachah with which one blesses Hashem brings down blessing from Up High to all the worlds.", "Zohar vol. 3 p. 270b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 36, "Every piece of food we eat should be considered a direct gift from Hashem, just like the manna that fell from Heaven.", "Rabbi Shimshon Rafael Hirsch, Devarim 8:10" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 37, "Yerushalayim will only be rebuilt when we praise and sing to Hashem.", "Midrash Tehilim 147:3" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 38, "The purpose of all the commandments is that we believe in Hashem and are thankful to Him for having created us; there is no other reason for our creation.", "Ramban, Shemot 13:16" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 39, "Even when Hashem has given us a large number of possessions, we must never forget to thank Him for each small thing.", "Derash Moshe p. 26" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 40, "The righteous praise and thank Hashem constantly for everything they eat, drink, see or hear.", "Midrash Tanchuma, Vezot Habrachah 7" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 41, "Gratitude is the foundation for serving Hashem.", "Alei Shur vol. 2 p. 283" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 42, "Rabbi Hamma taught, when a person blesses Hashem, Hashem will bless him too.", "Midrash Yalmedenu, Pinchas" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 43, "We are obligated to thank Hashem for everything.", "Berachot 46b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 44, "There is no person, whether poor or rich, healthy or sick, who doesn’t see numerous wonders and acts of kindness in their situation.", "Mesilat Yesharim 8" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 45, "Hashem gives us all that we need… air, water, light, clothing and shelter. We receive these benefits throughout our lives so we surely should be grateful and spend our lives expressing our thanks….", "Ohr Avigdor, Shaar Avodat Elokim" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 46, "When a person contemplates Hashem’s handiwork and phenomenal creations, he will observe wisdom that has no bounds. This will bring him to love and praise Him with an intense longing to know Him.", "Rambam, Yesodei Hatorah 2:2" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 47, "When we thank Hashem for a specific kindness, we will merit seeing many more.", "Devarim Achadim 32:2" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 48, "The korban todah had to be eaten together with forty loaves in only one night, so that there would be a meal served for many people; since gratitude needs to be publicised.", "Haemek Davar, Vayikra 7:13" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 49, "Rabbi Shimon taught, if someone who experiences a miracle will sing songs of praise to Hashem, then all of his sins will be forgiven and he will become a בריאה חדשה, a new being.", "Midrash Tehillim 18" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 50, "Hashem performs great miracles for us from the time we are born until the last day of our lives.", "Mesilat Yesharim 8" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 51, "People think holding a pen is simple and requires no strength and that only special strength is a gift. But really, even the strength needed to hold a pen is truly a Divine gift.", "Daat Chochmah U'Mussar vol. 1 p. 56-7" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 52, "The word הוד, glory, stems from the words הודאה, to thank. Expressing our gratitude is the ultimate way of glorifying Hashem.", "Based on Tikunai Zohar 13" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 53, "Anyone who increasingly thanks Hashem and extols Him constantly, is considered praiseworthy.", "Rambam, Hilchot Berachot 10:26" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 54, "Before we benefit from anything in this world we should pronounce Hashem’s name over it, blessing Him and realising that this good ultimately comes from Hashem.", "Derech Hashem 4:9:2" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 55, "One who knows how to praise Hashem appropriately, then He will answer their prayers and assist them.", "Zohar vol. 1 p. 178b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 56, "When we recognize Hashem's Goodness and thank Him, we will witness more of His Goodness.", "Derush V'chidush, Rabbi Akiva Eiger 1" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 57, "Hashem yearns for our blessings. Our blessings go Upwards and illuminate the Shechinah.", "Zohar vol. 3 p. 270b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 58, "One who remembers Hashem's Wonders will be saved from misfortunes.", "Peleh Yoetz, Niflaot" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 59, "Each Jew should be writing their own Megilat Esther, recording all the kindnesses and hidden miracles that they experience.", "Rabbi Chaim Shmulevitz" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 60, "The word להודות – to thank, shares the same root as the word מודה – to admit, since true gratitude is an expression of acknowledgment to our benefactor.", "Based on Bereishit Rabbah 71" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 61, "Songs of praise to Hashem brings down blessing from Heaven to all the worlds.", "Zohar vol. 3 p. 286a" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 62, "Each day we experience hundreds of minor pleasures in both material and spiritual aspects of our lives. We should focus on them and recognize Hashem's Kindnesses.", "Birkat Peretz, Eikev" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 63, "When we recite berachot with intent, they ascend until they reach the Kiseh Hakavod. Hashem is glorified by them and rejoices greatly; and the world is showered with bounty…", "Seder Hayom, Meah Berachot" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 64, "The more we believe that there is no such thing as nature and everything is a miracle, the more we will witness this.", "Michtav Me'Eliyahu vol. 1 p. 178" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 65, "People think that phenomena such as the resurrection of the dead is a miracle; is the sprouting of a seed any less miraculous?", "Siftei Chayim, Moadim vol. 3 p. 29 - 36" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 66, "Our sages instituted many blessings of praise, thanks and request so that we will remember Hashem constantly.", "Rambam, Hilchot Berachot 1:3" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 67, "Hashem Yitbarach performs kindnesses for every Jew. We must remember these acts constantly and never forget them. In the merit of this, we will be saved from the attribute of strict justice.", "Imrei Emet, Beshalach 592" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 68, "We should contemplate all the incredible gifts that Hashem entrusted with us. The knowledge, that all we have are gifts will motivate us to share them with others.", "Preface to Shaarei Yosher" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 69, "Pesukai dezimra is related to the words, zamer aritzim - cutting away evil forces, since songs of praise to Hashem help eradicate evil forces.", "Torat Moshe, Vayeilech" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 70, "One who thanks Hashem becomes so elevated that they cling to the Shechinah.", "Maharal, Gevurat Hashem 64" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 71, "Hashem desires the praise of Klal Yisrael on this earth the most; more than the praises of the malachim and the souls of tzadikim in Gan Eden.", "Ohr Hachayim, Bamidbar 16:22" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 72, "A person is obligated to thank and praise Hashem constantly, since His Kindnesses are with us constantly.", "Ibn Ezra, Kohelet 5:1" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 73, "We need to thank Hashem for the ability to thank Him.", "Based on the Modim DeRabanan prayer" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 74, "Whoever constantly thinks about the greatness of Hashem and the abundance of His Kindnesses will see the light inside the darkness, as well as miracles and wonders.", "Shomer Emunim, Maamar Hashgacha Pratit 23" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 75, "One who wants to serve Hashem and be truly in awe of Him, must first have a journal to record the kindnesses that He performs.", "Sefer Hayashar 13" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 76, "An important rule. For every success, whether big or small, one should thank and praise Hashem Yitbarach, for causing it to occur.", "Shelah, Eikev, Derech Hachaim Tochechot Mussar" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 77, "According to how much a person blesses Hashem with happiness and ayin tovah, Hashem will shower him with blessings, happiness and ayin tovah. ", "Zohar vol. 2 p. 218a" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 78, "The fact we begin our day with modeh ani shows us how gratitude is the purpose of everything. Everything is drawn from the beginning.", "Nefesh Shimshon, Tefillah p. 9" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 79, "Whoever sincerely feels gratitude will not be sparing with words, but will go into great detail…", "Lail Shimurim p.115" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 80, "בראשית when rearranged spells תאב שיר, i.e. ‘desires (our) song’, since Hashem created the world so that He could hear our songs of praise.", "Zohar Chadash vol. 1 p. 12b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 81, "When we feel inspired to thank Hashem for a specific thing, we should also strive to thank Him for general kindnesses that He does for us on a constant basis.", "Sfat Emet, Tehillim 100:1" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 82, "Reciting the berachah of pokeach ivrim with intent, appreciating the incredible gift of eyesight, is a segulah never to have problems with vision.", "Nefesh Shimshon, Tefillah p. 68" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 83, "One needs to constantly praise Hashem, since He desires the songs and praises of Klal Yisrael.", "Zohar vol. 1 p. 178b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 84, "One should always be working on the trait of gratitude for both our physical and spiritual gifts.", "Chochmah U'mussar vol. 2 p. 321" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 85, "One should strive to recite the berachah of asher yatzar with intent, having in mind the incredible kindnesses of Hashem… One who does this will be guaranteed to always be healthy.", "Seder Hayom, Kavanat Haberachot" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 86, "The reason for the mitzvah of kibud av va’aim is that we need to show gratitude to those who have benefited us and not to be an ingrate.", "Sefer Hachinuch 33" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 87, "One who is benefitted in a seemingly roundabout way should still thank Hashem, since He carefully planned it. Nothing is coincidental", "Maharal, Gevurat Hashem 64" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 88, "Hashem in His great Kindness desires to do good to us… we must thank Him, recognising that He is the Master of the Universe, Who always does good and continues to do good.", "Alshich, Devarim 26:2" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 89, "The trait of gratitude is the crown of all good attributes.", "Ohr Yehezkel, Michtav 12" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 90, "It is a great segulah in a time of trouble to pledge to say nishmas kol chai with a minyan when we see a salvation. Many have seen success with this.", "Rabbi Yehdah HaChassid, quoted in Kaf HaChayim 281:8" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 91, "The one hundred berachot that we recite daily are keys that open Hashem’s treasury to shower countless blessings upon us. As a result, we will receive physical abundance and reach spiritual heights.", "Zohar vol. 1 p. 76b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 92, "When a person encounters challenges, yet feels happy and accepts everything with love, Hashem will give him a reason to be happy and things will get better.", "Shaarei Teshuvah 4:12" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 93, "A person should thank Hashem for all his previous benefits…", "Berachot 54a" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 94, "The more one excels in the trait of gratitude, the more it bespeaks one's good qualities.", "Lev Eliyahu, Ma’arachot Hateshuvot 1" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 95, "Hashem created man so that he would recognize his Creator and thank Him.", "Ramban, Devarim 32:26" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 96, "Since gratitude is such a fundamental trait, our yetzer hara works extra hard to distance us from this precious quality.", "Ohr Hachayim, Devarim 8:18" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 97, "Hashem only redeemed Klal Yisrael and performed miracles so that we recount these wonders.", "Midrash Tehillim 70" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 98, "The word קללה – curse, when reversed spells ק הלל – praising Hashem with a hundred (blessings). When we praise Hashem by reciting a hundred blessings daily, we have the power to reverse any curse into a blessing!", "Arizal quoted in Sefer HaGan" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 99, "Reciting מזמור לתודה is considered as if we have brought a korban todah!", "Kav Hayashar 8" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 100, "We conclude each prayer with עלינו, to reinforce that the purpose of everything is to reach the level of עלינו לשבח לאדון הכל – it is incumbent upon us to praise the Master of Everything.", "Nefesh Shimshon, Tefillah p .9" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 101, "One who shows gratitude to those who have benefited them, will receive more benefit from them.", "Derush V'chidush, Rabbi Akiva Eiger 1" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 102, "Recounting Hashem’s miracles forms a special closeness with Him and removes all the darkness that separates us from Him.", "Shelah, Haggadah Shel Pesach, Kol hamarbeh" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 103, "One needs to contemplate deeply everything Hashem has done for them, from when one was born until the present day, and be grateful for those gifts.", "Orchot Tzadikim, Shaar Hateshuvah" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 104, "We should emulate David Hamelech, and compose our own personal book of Tehillim, recounting the kindnesses and salvations that Hashem does for us.", "Alei Shur vol. 2 p. 285" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 105, "One is obligated to bless netilas yadayim in the morning to express gratitude to Hashem that He created us as a new entity.", "Levush, O.C. 6:1" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 106, "The reason why the Modim prayer is the only blessing that the congregation recite together with the chazzan's repetition, is because we need to thank Hashem directly ourselves, and not only through a messenger.", "Abudraham, Shemoneh Esrei" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 107, "The redemption will come in the merit of singing pleasant tunes to Hashem.", "Tikunai Zohar 21 p. 51b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 108, "When we recite a berachah before eating or drinking, a shefa kedoshah - holy abundance, comes to rest upon the food or drink.", "Peleh Yoetz, Berachot" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 109, "Hashem Yisbarach is revealed in the world through the great kindnesses that He performs. These kindnesses are so that we recognize Him, by blessing and praising Him.", "Nefesh Shimshon, Tefillah p. 68" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 110, "When Mashiach comes, all the sacrifices will be nullified except for the korban todah, the thanksgiving offering.", "Vayikra Rabbah 9:7" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 111, "In addition to thanking Hashem for our current situation, we should focus on the bigger picture, contrasting how hard things were previously, so as to highlight our gratitude.", "Rabbeinu Bechaya, Bereishit 32:11" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 112, "It is incumbent upon mankind that we praise Hashem.", "Bereishit Rabbah 1:5" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 113, "When a Jew thanks Hashem, the forces of evil will be chased away and he will be saved from evil occurrences.", "Hiko Mamtakim p. 93" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 114, "A person must focus his heart at all times to honor Hashem and sanctify His Name, to praise, thank and bless Him constantly…", "Shaarei Teshuvah 3" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 115, "The most direct way to obtain a clear knowledge of Hashem’s presence, is by examining the wisdom in His Creations.", "Chovot Halelavot, hakdama to Shaar HaBechinah" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 116, "One should recite עלינו לשבח with awe and fear since all the Heavenly hosts come and listen, and Hashem is standing there with them…", "Mishnah Berurah 132:8" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 117, "Hashem's only desire is that we humans be aware and thank Him for creating us.", "Ramban, Shemot 13:16" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 118, " When we reflect upon the infinite kindnesses that Hashem bestowed upon us from the moment we were conceived, we would be humbled before Him… and subsequently compelled to repent.", "Sefer Chareidim 9:23" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 119, "When we believe in Hashem’s guiding Hand and internalise that we have everything we need, it is a special עת רצון - time of favor.", "Kedushat Levi, Derush LaPesach" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 120, "One who is careful with reciting a hundred berachot daily will be blessed with prosperity.", "Ohr Hachayim, Devarim 10:12" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 121, "It is incumbent on a person to ask himself who is giving him all that he has? From where does he have health, livelihood and life?", "Yad Yehezkel p. 37" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 122, "By mastering an attitude of gratitude, we will become more spiritual people.", "Chovot Halevavot, Shaar Avodat Elokim" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 123, "With each mitzvah we perform, we must thank and praise Hashem, Who gave us this opportunity and enabled us to receive spiritual perfection in this world and the next.", "Levush O.C. 8:1" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 124, "The word מחשבה – mindset when rearranged spells בשמחה – happiness, (since true happiness depends on our mindset and appreciating what we have.)", "Tikunai Zohar 22, p. 63b" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 125, "Whoever has the Shem Shamayim present on their lips, praying and expressing gratitude for every small thing, will be granted great success in all their endeavours.", "Shomer Emunim, Maamar Hashgacha Pratit 23" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 126, "One should constantly speak of the good that Hashem does for him, and thank and praise Him abundantly, both in his heart and his words.", "Chovot Halevavot, Shaar Avodat Elokim 7" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 127, "When we recite one hundred blessings daily, we open one hundred gates of blessing.", "Rekanati, Bereishit 26:12" });

    migrationBuilder.InsertData(
        table: "Quotes",
        columns: new[] { "Id", "QuotedText", "Source" },
        values: new object[] { 128, "Gratitude is the crown that shines the most in the treasure house of a person’s life accomplishments.", "Ketav Sofer, Derashah for Shabbat Hagadol 5608" });

    migrationBuilder.InsertData(
        table: "Settings",
        columns: new[] { "Id", "Interval", "LastUpdated", "NotifText", "RunOnStartUp", "ShowSplashScreen", "UseRandomQuote" },
        values: new object[] { 1, 30, new DateTime(2023, 9, 26, 15, 16, 28, 256, DateTimeKind.Local).AddTicks(1460), "", true, true, true });
  }

  protected override void Down(MigrationBuilder migrationBuilder) {
    migrationBuilder.DropTable(
        name: "Quotes");

    migrationBuilder.DropTable(
        name: "Settings");
  }
}
