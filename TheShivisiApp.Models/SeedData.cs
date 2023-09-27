using Microsoft.EntityFrameworkCore;

namespace TheShivisiApp.Models;

public class SeedData {
  public static void TheData(ModelBuilder modelBuilder) {
    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 1,
      QuotedText = "We should accustom ourselves to express gratitude for the benefits we have enjoyed, thanking and praising Hashem to the best of our ability.",
      Source = "Rambam, Hilchot Berachot 10:26"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 2,
      QuotedText = "Klal Yisrael are more beloved than the angels, since the angels do not praise Hashem in Heaven until we praise Him in this world below.",
      Source = "Chullin 91b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 3,
      QuotedText = "When we sing songs of praise to Hashem, our sins are forgiven.",
      Source = "Midrash Tehillim 18"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 4,
      QuotedText = "Our mouth was created in order to thank Hashem and praise Him.",
      Source = "Magen Avraham O.C. 60:2"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 5,
      QuotedText = "A person who lives with a constant awareness of Hashem’s guiding hand will have a life of unrestricted happiness.",
      Source = "Emunah U'bitachon 1:9"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 6,
      QuotedText = "We are obligated to focus on and continuously remember Hashem’s constant kindness.",
      Source = "Kad Hakemach, Purim"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 7,
      QuotedText = "Everything that happens to us is all miracles; there is no such thing as nature.",
      Source = "Ramban, Shemot 13:16"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 8,
      QuotedText = "Observing all the benefits we receive from Hashem will inspire us to serve Him.",
      Source = "Mesilat Yesharim 8"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 9,
      QuotedText = "One who knows how to praise Hashem, increases blessings in the upper and lower realms. He is beloved on high, esteemed below and Hashem takes pride in him.",
      Source = "Zohar vol. 1 p. 59b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 10,
      QuotedText = "The first rule in serving Hashem is to thank Him - that is the basis of everything.",
      Source = "Ohr Avigdor Shaar HaBechinah"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 11,
      QuotedText = "There is no individual in Klal Yisrael for whom hidden miracles do not occur each day.",
      Source = "Rabbeinu Bechaya, Shemot 30:12"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 12,
      QuotedText = "Even though Hashem has thousands and myriads of angels who praise Him, He only desires the praises of Klal Yisrael.",
      Source = "Midrash Mishlei 14:28"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 13,
      QuotedText = "With every breath that we breathe, we should praise Hashem.",
      Source = "Bereishit Rabbah 14:11"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 14,
      QuotedText = "The Jewish nation are not called Reuvenim or Shimonim, rather Yehudim (from the word to thank, since this is our essence).",
      Source = "Bereishit Rabbah 98:6"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 15,
      QuotedText = "When we praise Hashem with a pleasant voice and intent, we merit to enter Gan Eden.",
      Source = "Ohr Zarua, Shabbat 42:7"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 16,
      QuotedText = "Appreciation enhances our joy of life. Without it, one goes through life like a person in a drunken state, not feeling the pleasure and enjoyment of their many blessings.",
      Source = "Kuzari 3:16"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 17,
      QuotedText = "When Klal Yisrael speak about the wonders and awesome phenomena of Hashem… the angels praise Him for having such a precious nation.",
      Source = "Zohar vol. 2 p. 40b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 18,
      QuotedText = "Mankind was created to praise and to thank Hashem as well as to serve and fear Him. Those who do so are upholding the world.",
      Source = "Shitah Mikubetzet, Berachot 6b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 19,
      QuotedText = "Were it not for Klal Yisrael’s songs and praises to Hashem, the world would not have been created.",
      Source = "Midrash Otiyot DeRabbi Akiva 1"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 20,
      QuotedText = "Through song and praises to Hashem we can open the gates of Heaven. When these gates are open, we can request whatever we need.",
      Source = "Tiferet Shlomo, Ki Tisa"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 21,
      QuotedText = "When we thank Hashem for all the good that we receive, it is considered as if we brought a korban todah. Consequently, we and the entire world will receive more kindnesses.",
      Source = "Shomer Emunim, Maamar Hashgacha Pratit 23"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 22,
      QuotedText = "Rabbi Yehoshua Ben Levi said, anyone who sings praises to Hashem in this world will merit to sing praises to Him in the world to come.",
      Source = "Sanhedrin 91b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 23,
      QuotedText = "Each Jew should strive to remember the kindnesses that Hashem does for him on a constant basis.",
      Source = "Sefer Charedim 9:23"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 24,
      QuotedText = "If gratitude ceased to exist, how would the world carry on?",
      Source = "Akeidat Yitzchak, Ki Tisa 181"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 25,
      QuotedText = "When we thank Hashem for a miracle that He has done for us, we will be saved from other misfortunes.",
      Source = "Midrash Tehillim 70"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 26,
      QuotedText = "We should contemplate all the kindnesses that Hashem has done for us from the moment we were born.",
      Source = "Sefer Hayashar 14"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 27,
      QuotedText = "Every day we should strive to thank Hashem for more of His Kindnesses and Wisdom.",
      Source = "Chovot Halevovot, Shaar HaBechinah 6"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 28,
      QuotedText = "It is our obligation to praise and thank Hashem for His Unlimited Goodness.",
      Source = "Chovot Halevavot, hakdama to Shaar Avodat Elokim"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 29,
      QuotedText = "Remembering Hashem’s kindnesses and contemplating them is a mitzvah from the Torah.",
      Source = "Shaarei Teshuvah 3:17"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 30,
      QuotedText = "All our existence in this world is for one reason - to thank Hashem.",
      Source = "Alei Shur vol. 2 p. 283"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 31,
      QuotedText = "Every praise with which Klal Yisroel extolls Hashem causes the Shechinah to dwell amongst them.",
      Source = "Midrash Tehillim 18"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 32,
      QuotedText = "When a Jew rejoices over Hashem’s kindnesses and thanks Him for all the good that He constantly does, he will be saved from sinning and bad occurrences.",
      Source = "Torat Avot p. 170"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 33,
      QuotedText = "Hashem longs for the prayers of Klal Yisrael, and their praises are beloved to Him more than anything else.",
      Source = "Talmud Yerushalmi quoted in Tosafot Succah 53a"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 34,
      QuotedText = "It is appropriate for us to set a fixed time for thanking Hashem.",
      Source = "Peleh Yoetz, Hillul"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 35,
      QuotedText = "A berachah with which one blesses Hashem brings down blessing from Up High to all the worlds.",
      Source = "Zohar vol. 3 p. 270b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 36,
      QuotedText = "Every piece of food we eat should be considered a direct gift from Hashem, just like the manna that fell from Heaven.",
      Source = "Rabbi Shimshon Rafael Hirsch, Devarim 8:10"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 37,
      QuotedText = "Yerushalayim will only be rebuilt when we praise and sing to Hashem.",
      Source = "Midrash Tehilim 147:3"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 38,
      QuotedText = "The purpose of all the commandments is that we believe in Hashem and are thankful to Him for having created us; there is no other reason for our creation.",
      Source = "Ramban, Shemot 13:16"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 39,
      QuotedText = "Even when Hashem has given us a large number of possessions, we must never forget to thank Him for each small thing.",
      Source = "Derash Moshe p. 26"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 40,
      QuotedText = "The righteous praise and thank Hashem constantly for everything they eat, drink, see or hear.",
      Source = "Midrash Tanchuma, Vezot Habrachah 7"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 41,
      QuotedText = "Gratitude is the foundation for serving Hashem.",
      Source = "Alei Shur vol. 2 p. 283"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 42,
      QuotedText = "Rabbi Hamma taught, when a person blesses Hashem, Hashem will bless him too.",
      Source = "Midrash Yalmedenu, Pinchas"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 43,
      QuotedText = "We are obligated to thank Hashem for everything.",
      Source = "Berachot 46b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 44,
      QuotedText = "There is no person, whether poor or rich, healthy or sick, who doesn’t see numerous wonders and acts of kindness in their situation.",
      Source = "Mesilat Yesharim 8"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 45,
      QuotedText = "Hashem gives us all that we need… air, water, light, clothing and shelter. We receive these benefits throughout our lives so we surely should be grateful and spend our lives expressing our thanks….",
      Source = "Ohr Avigdor, Shaar Avodat Elokim"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 46,
      QuotedText = "When a person contemplates Hashem’s handiwork and phenomenal creations, he will observe wisdom that has no bounds. This will bring him to love and praise Him with an intense longing to know Him.",
      Source = "Rambam, Yesodei Hatorah 2:2"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 47,
      QuotedText = "When we thank Hashem for a specific kindness, we will merit seeing many more.",
      Source = "Devarim Achadim 32:2"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 48,
      QuotedText = "The korban todah had to be eaten together with forty loaves in only one night, so that there would be a meal served for many people; since gratitude needs to be publicised.",
      Source = "Haemek Davar, Vayikra 7:13"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 49,
      QuotedText = "Rabbi Shimon taught, if someone who experiences a miracle will sing songs of praise to Hashem, then all of his sins will be forgiven and he will become a בריאה חדשה, a new being.",
      Source = "Midrash Tehillim 18"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 50,
      QuotedText = "Hashem performs great miracles for us from the time we are born until the last day of our lives.",
      Source = "Mesilat Yesharim 8"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 51,
      QuotedText = "People think holding a pen is simple and requires no strength and that only special strength is a gift. But really, even the strength needed to hold a pen is truly a Divine gift.",
      Source = "Daat Chochmah U'Mussar vol. 1 p. 56-7"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 52,
      QuotedText = "The word הוד, glory, stems from the words הודאה, to thank. Expressing our gratitude is the ultimate way of glorifying Hashem.",
      Source = "Based on Tikunai Zohar 13"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 53,
      QuotedText = "Anyone who increasingly thanks Hashem and extols Him constantly, is considered praiseworthy.",
      Source = "Rambam, Hilchot Berachot 10:26"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 54,
      QuotedText = "Before we benefit from anything in this world we should pronounce Hashem’s name over it, blessing Him and realising that this good ultimately comes from Hashem.",
      Source = "Derech Hashem 4:9:2"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 55,
      QuotedText = "One who knows how to praise Hashem appropriately, then He will answer their prayers and assist them.",
      Source = "Zohar vol. 1 p. 178b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 56,
      QuotedText = "When we recognize Hashem's Goodness and thank Him, we will witness more of His Goodness.",
      Source = "Derush V'chidush, Rabbi Akiva Eiger 1"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 57,
      QuotedText = "Hashem yearns for our blessings. Our blessings go Upwards and illuminate the Shechinah.",
      Source = "Zohar vol. 3 p. 270b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 58,
      QuotedText = "One who remembers Hashem's Wonders will be saved from misfortunes.",
      Source = "Peleh Yoetz, Niflaot"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 59,
      QuotedText = "Each Jew should be writing their own Megilat Esther, recording all the kindnesses and hidden miracles that they experience.",
      Source = "Rabbi Chaim Shmulevitz"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 60,
      QuotedText = "The word להודות – to thank, shares the same root as the word מודה – to admit, since true gratitude is an expression of acknowledgment to our benefactor.",
      Source = "Based on Bereishit Rabbah 71"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 61,
      QuotedText = "Songs of praise to Hashem brings down blessing from Heaven to all the worlds.",
      Source = "Zohar vol. 3 p. 286a"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 62,
      QuotedText = "Each day we experience hundreds of minor pleasures in both material and spiritual aspects of our lives. We should focus on them and recognize Hashem's Kindnesses.",
      Source = "Birkat Peretz, Eikev"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 63,
      QuotedText = "When we recite berachot with intent, they ascend until they reach the Kiseh Hakavod. Hashem is glorified by them and rejoices greatly; and the world is showered with bounty…",
      Source = "Seder Hayom, Meah Berachot"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 64,
      QuotedText = "The more we believe that there is no such thing as nature and everything is a miracle, the more we will witness this.",
      Source = "Michtav Me'Eliyahu vol. 1 p. 178"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 65,
      QuotedText = "People think that phenomena such as the resurrection of the dead is a miracle; is the sprouting of a seed any less miraculous?",
      Source = "Siftei Chayim, Moadim vol. 3 p. 29 - 36"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 66,
      QuotedText = "Our sages instituted many blessings of praise, thanks and request so that we will remember Hashem constantly.",
      Source = "Rambam, Hilchot Berachot 1:3"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 67,
      QuotedText = "Hashem Yitbarach performs kindnesses for every Jew. We must remember these acts constantly and never forget them. In the merit of this, we will be saved from the attribute of strict justice.",
      Source = "Imrei Emet, Beshalach 592"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 68,
      QuotedText = "We should contemplate all the incredible gifts that Hashem entrusted with us. The knowledge, that all we have are gifts will motivate us to share them with others.",
      Source = "Preface to Shaarei Yosher"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 69,
      QuotedText = "Pesukai dezimra is related to the words, zamer aritzim - cutting away evil forces, since songs of praise to Hashem help eradicate evil forces.",
      Source = "Torat Moshe, Vayeilech"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 70,
      QuotedText = "One who thanks Hashem becomes so elevated that they cling to the Shechinah.",
      Source = "Maharal, Gevurat Hashem 64"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 71,
      QuotedText = "Hashem desires the praise of Klal Yisrael on this earth the most; more than the praises of the malachim and the souls of tzadikim in Gan Eden.",
      Source = "Ohr Hachayim, Bamidbar 16:22"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 72,
      QuotedText = "A person is obligated to thank and praise Hashem constantly, since His Kindnesses are with us constantly.",
      Source = "Ibn Ezra, Kohelet 5:1"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 73,
      QuotedText = "We need to thank Hashem for the ability to thank Him.",
      Source = "Based on the Modim DeRabanan prayer"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 74,
      QuotedText = "Whoever constantly thinks about the greatness of Hashem and the abundance of His Kindnesses will see the light inside the darkness, as well as miracles and wonders.",
      Source = "Shomer Emunim, Maamar Hashgacha Pratit 23"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 75,
      QuotedText = "One who wants to serve Hashem and be truly in awe of Him, must first have a journal to record the kindnesses that He performs.",
      Source = "Sefer Hayashar 13"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 76,
      QuotedText = "An important rule. For every success, whether big or small, one should thank and praise Hashem Yitbarach, for causing it to occur.",
      Source = "Shelah, Eikev, Derech Hachaim Tochechot Mussar"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 77,
      QuotedText = "According to how much a person blesses Hashem with happiness and ayin tovah, Hashem will shower him with blessings, happiness and ayin tovah. ",
      Source = "Zohar vol. 2 p. 218a"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 78,
      QuotedText = "The fact we begin our day with modeh ani shows us how gratitude is the purpose of everything. Everything is drawn from the beginning.",
      Source = "Nefesh Shimshon, Tefillah p. 9"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 79,
      QuotedText = "Whoever sincerely feels gratitude will not be sparing with words, but will go into great detail…",
      Source = "Lail Shimurim p.115"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 80,
      QuotedText = "בראשית when rearranged spells תאב שיר, i.e. ‘desires (our) song’, since Hashem created the world so that He could hear our songs of praise.",
      Source = "Zohar Chadash vol. 1 p. 12b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 81,
      QuotedText = "When we feel inspired to thank Hashem for a specific thing, we should also strive to thank Him for general kindnesses that He does for us on a constant basis.",
      Source = "Sfat Emet, Tehillim 100:1"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 82,
      QuotedText = "Reciting the berachah of pokeach ivrim with intent, appreciating the incredible gift of eyesight, is a segulah never to have problems with vision.",
      Source = "Nefesh Shimshon, Tefillah p. 68"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 83,
      QuotedText = "One needs to constantly praise Hashem, since He desires the songs and praises of Klal Yisrael.",
      Source = "Zohar vol. 1 p. 178b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 84,
      QuotedText = "One should always be working on the trait of gratitude for both our physical and spiritual gifts.",
      Source = "Chochmah U'mussar vol. 2 p. 321"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 85,
      QuotedText = "One should strive to recite the berachah of asher yatzar with intent, having in mind the incredible kindnesses of Hashem… One who does this will be guaranteed to always be healthy.",
      Source = "Seder Hayom, Kavanat Haberachot"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 86,
      QuotedText = "The reason for the mitzvah of kibud av va’aim is that we need to show gratitude to those who have benefited us and not to be an ingrate.",
      Source = "Sefer Hachinuch 33"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 87,
      QuotedText = "One who is benefitted in a seemingly roundabout way should still thank Hashem, since He carefully planned it. Nothing is coincidental",
      Source = "Maharal, Gevurat Hashem 64"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 88,
      QuotedText = "Hashem in His great Kindness desires to do good to us… we must thank Him, recognising that He is the Master of the Universe, Who always does good and continues to do good.",
      Source = "Alshich, Devarim 26:2"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 89,
      QuotedText = "The trait of gratitude is the crown of all good attributes.",
      Source = "Ohr Yehezkel, Michtav 12"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 90,
      QuotedText = "It is a great segulah in a time of trouble to pledge to say nishmas kol chai with a minyan when we see a salvation. Many have seen success with this.",
      Source = "Rabbi Yehdah HaChassid, quoted in Kaf HaChayim 281:8"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 91,
      QuotedText = "The one hundred berachot that we recite daily are keys that open Hashem’s treasury to shower countless blessings upon us. As a result, we will receive physical abundance and reach spiritual heights.",
      Source = "Zohar vol. 1 p. 76b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 92,
      QuotedText = "When a person encounters challenges, yet feels happy and accepts everything with love, Hashem will give him a reason to be happy and things will get better.",
      Source = "Shaarei Teshuvah 4:12"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 93,
      QuotedText = "A person should thank Hashem for all his previous benefits…",
      Source = "Berachot 54a"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 94,
      QuotedText = "The more one excels in the trait of gratitude, the more it bespeaks one's good qualities.",
      Source = "Lev Eliyahu, Ma’arachot Hateshuvot 1"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 95,
      QuotedText = "Hashem created man so that he would recognize his Creator and thank Him.",
      Source = "Ramban, Devarim 32:26"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 96,
      QuotedText = "Since gratitude is such a fundamental trait, our yetzer hara works extra hard to distance us from this precious quality.",
      Source = "Ohr Hachayim, Devarim 8:18"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 97,
      QuotedText = "Hashem only redeemed Klal Yisrael and performed miracles so that we recount these wonders.",
      Source = "Midrash Tehillim 70"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 98,
      QuotedText = "The word קללה – curse, when reversed spells ק הלל – praising Hashem with a hundred (blessings). When we praise Hashem by reciting a hundred blessings daily, we have the power to reverse any curse into a blessing!",
      Source = "Arizal quoted in Sefer HaGan"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 99,
      QuotedText = "Reciting מזמור לתודה is considered as if we have brought a korban todah!",
      Source = "Kav Hayashar 8"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 100,
      QuotedText = "We conclude each prayer with עלינו, to reinforce that the purpose of everything is to reach the level of עלינו לשבח לאדון הכל – it is incumbent upon us to praise the Master of Everything.",
      Source = "Nefesh Shimshon, Tefillah p .9"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 101,
      QuotedText = "One who shows gratitude to those who have benefited them, will receive more benefit from them.",
      Source = "Derush V'chidush, Rabbi Akiva Eiger 1"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 102,
      QuotedText = "Recounting Hashem’s miracles forms a special closeness with Him and removes all the darkness that separates us from Him.",
      Source = "Shelah, Haggadah Shel Pesach, Kol hamarbeh"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 103,
      QuotedText = "One needs to contemplate deeply everything Hashem has done for them, from when one was born until the present day, and be grateful for those gifts.",
      Source = "Orchot Tzadikim, Shaar Hateshuvah"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 104,
      QuotedText = "We should emulate David Hamelech, and compose our own personal book of Tehillim, recounting the kindnesses and salvations that Hashem does for us.",
      Source = "Alei Shur vol. 2 p. 285"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 105,
      QuotedText = "One is obligated to bless netilas yadayim in the morning to express gratitude to Hashem that He created us as a new entity.",
      Source = "Levush, O.C. 6:1"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 106,
      QuotedText = "The reason why the Modim prayer is the only blessing that the congregation recite together with the chazzan's repetition, is because we need to thank Hashem directly ourselves, and not only through a messenger.",
      Source = "Abudraham, Shemoneh Esrei"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 107,
      QuotedText = "The redemption will come in the merit of singing pleasant tunes to Hashem.",
      Source = "Tikunai Zohar 21 p. 51b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 108,
      QuotedText = "When we recite a berachah before eating or drinking, a shefa kedoshah - holy abundance, comes to rest upon the food or drink.",
      Source = "Peleh Yoetz, Berachot"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 109,
      QuotedText = "Hashem Yisbarach is revealed in the world through the great kindnesses that He performs. These kindnesses are so that we recognize Him, by blessing and praising Him.",
      Source = "Nefesh Shimshon, Tefillah p. 68"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 110,
      QuotedText = "When Mashiach comes, all the sacrifices will be nullified except for the korban todah, the thanksgiving offering.",
      Source = "Vayikra Rabbah 9:7"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 111,
      QuotedText = "In addition to thanking Hashem for our current situation, we should focus on the bigger picture, contrasting how hard things were previously, so as to highlight our gratitude.",
      Source = "Rabbeinu Bechaya, Bereishit 32:11"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 112,
      QuotedText = "It is incumbent upon mankind that we praise Hashem.",
      Source = "Bereishit Rabbah 1:5"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 113,
      QuotedText = "When a Jew thanks Hashem, the forces of evil will be chased away and he will be saved from evil occurrences.",
      Source = "Hiko Mamtakim p. 93"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 114,
      QuotedText = "A person must focus his heart at all times to honor Hashem and sanctify His Name, to praise, thank and bless Him constantly…",
      Source = "Shaarei Teshuvah 3"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 115,
      QuotedText = "The most direct way to obtain a clear knowledge of Hashem’s presence, is by examining the wisdom in His Creations.",
      Source = "Chovot Halelavot, hakdama to Shaar HaBechinah"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 116,
      QuotedText = "One should recite עלינו לשבח with awe and fear since all the Heavenly hosts come and listen, and Hashem is standing there with them…",
      Source = "Mishnah Berurah 132:8"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 117,
      QuotedText = "Hashem's only desire is that we humans be aware and thank Him for creating us.",
      Source = "Ramban, Shemot 13:16"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 118,
      QuotedText = " When we reflect upon the infinite kindnesses that Hashem bestowed upon us from the moment we were conceived, we would be humbled before Him… and subsequently compelled to repent.",
      Source = "Sefer Chareidim 9:23"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 119,
      QuotedText = "When we believe in Hashem’s guiding Hand and internalise that we have everything we need, it is a special עת רצון - time of favor.",
      Source = "Kedushat Levi, Derush LaPesach"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 120,
      QuotedText = "One who is careful with reciting a hundred berachot daily will be blessed with prosperity.",
      Source = "Ohr Hachayim, Devarim 10:12"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 121,
      QuotedText = "It is incumbent on a person to ask himself who is giving him all that he has? From where does he have health, livelihood and life?",
      Source = "Yad Yehezkel p. 37"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 122,
      QuotedText = "By mastering an attitude of gratitude, we will become more spiritual people.",
      Source = "Chovot Halevavot, Shaar Avodat Elokim"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 123,
      QuotedText = "With each mitzvah we perform, we must thank and praise Hashem, Who gave us this opportunity and enabled us to receive spiritual perfection in this world and the next.",
      Source = "Levush O.C. 8:1"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 124,
      QuotedText = "The word מחשבה – mindset when rearranged spells בשמחה – happiness, (since true happiness depends on our mindset and appreciating what we have.)",
      Source = "Tikunai Zohar 22, p. 63b"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 125,
      QuotedText = "Whoever has the Shem Shamayim present on their lips, praying and expressing gratitude for every small thing, will be granted great success in all their endeavours.",
      Source = "Shomer Emunim, Maamar Hashgacha Pratit 23"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 126,
      QuotedText = "One should constantly speak of the good that Hashem does for him, and thank and praise Him abundantly, both in his heart and his words.",
      Source = "Chovot Halevavot, Shaar Avodat Elokim 7"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 127,
      QuotedText = "When we recite one hundred blessings daily, we open one hundred gates of blessing.",
      Source = "Rekanati, Bereishit 26:12"
    });

    modelBuilder.Entity<Quote>().HasData(new Quote {
      Id = 128,
      QuotedText = "Gratitude is the crown that shines the most in the treasure house of a person’s life accomplishments.",
      Source = "Ketav Sofer, Derashah for Shabbat Hagadol 5608"
    });
  }
}