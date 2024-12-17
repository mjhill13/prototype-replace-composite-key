using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ReplaceCompositeKey.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entities",
                columns: table => new
                {
                    Prop1 = table.Column<string>(type: "text", nullable: false),
                    Prop2 = table.Column<string>(type: "text", nullable: false),
                    OtherProp = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entities", x => new { x.Prop1, x.Prop2 });
                });

            migrationBuilder.InsertData(
                table: "Entities",
                columns: new[] { "Prop1", "Prop2", "OtherProp" },
                values: new object[,]
                {
                    { "0dl3vdyk", "wct3f50y", "Est qui repellat sit sit voluptas." },
                    { "18pgl83z", "o5zadecp", "Praesentium qui quisquam vero ab voluptas nisi adipisci voluptas." },
                    { "1mrfw4pp", "v7f840dl", "Quibusdam id enim aut recusandae." },
                    { "1suu4jiw", "ekdfbkrb", "Qui facere exercitationem consequatur necessitatibus architecto aut dolores." },
                    { "25zdlgpt", "e8bqsl8x", "Laborum culpa minus." },
                    { "2btux92l", "0fvw6348", "Nam sint dolorem quia voluptas magnam." },
                    { "2c0fjclw", "mvin26we", "Dolores quasi saepe minima eaque sunt ea dolorum." },
                    { "34jhxdq5", "9f612906", "Vitae minima minima." },
                    { "3kwjhdi3", "h2bxldto", "Omnis laboriosam laborum labore." },
                    { "48w68t5f", "g543pu2p", "Debitis minus autem non enim error vero ea voluptatem a." },
                    { "4teqw57o", "zcq1o30c", "Consequatur qui provident impedit." },
                    { "53bitdbx", "09j6obqd", "Ut magni ut culpa vero quia harum." },
                    { "5ewses0w", "vh289svd", "Placeat aut sit animi veniam sint." },
                    { "5k8b928t", "5tm3qkry", "Ex quia atque aut ducimus facilis." },
                    { "5nla5tfs", "ey8x7uii", "Autem et aliquid et voluptatum." },
                    { "5s0vkjnw", "q474aq8v", "Beatae a voluptate veniam sint doloribus quam deleniti ut perferendis." },
                    { "65upkvme", "2rv90kbd", "Deleniti vero reprehenderit nemo reprehenderit inventore quia praesentium et." },
                    { "69voocjs", "blt1mwnq", "Incidunt voluptate laboriosam est veritatis aliquam itaque qui rem." },
                    { "6kqwe0hc", "ux5pef8z", "Cupiditate ducimus perferendis possimus officia." },
                    { "6n9ncoog", "5a3qjdrf", "Vel id suscipit harum aut sint quasi ipsum eius pariatur." },
                    { "6wcqd1yi", "ebhwcnua", "Et autem quis voluptas voluptas nisi minus est." },
                    { "73rsauu1", "4pda3qr1", "Natus eum minus reiciendis." },
                    { "78947am8", "l26z4y8s", "Neque natus nulla temporibus placeat quo maiores ea nostrum nemo." },
                    { "7uocz4u7", "eand82pd", "Aut et dolor ducimus." },
                    { "8076b39n", "0lqhz9sa", "Sed dolore doloribus quibusdam laborum quibusdam aperiam quia." },
                    { "87xs10c8", "wn2k1bjk", "Et impedit velit ab." },
                    { "8cbzzg19", "zs7sg03u", "Vel autem et et aut aut." },
                    { "8mmpfnta", "c2rujn7h", "Id earum deleniti qui consequatur quos voluptates fugit saepe." },
                    { "8tu1bfsb", "y2nf9xtf", "Aperiam vel laboriosam rerum." },
                    { "8wqzo9ts", "yn41mw56", "Id voluptatem quisquam sit aut quibusdam porro." },
                    { "95vqvwpj", "bueb21mb", "Quibusdam sint officiis." },
                    { "989ckcyo", "z4n8k5zc", "Similique in dolor aut ut et maiores autem sit est." },
                    { "98uxl937", "5825qd6m", "Ad voluptatem at." },
                    { "9dhncewv", "5wnym3ki", "Quis incidunt non ipsam sit." },
                    { "9l761pix", "06mibxbv", "Explicabo sunt hic eos aut pariatur." },
                    { "av9pv40r", "800m820m", "Aperiam laboriosam enim a." },
                    { "c5e00ghu", "oc030xxz", "Ipsum dolore non et enim vel eos." },
                    { "cgr3tpuw", "eauw1j0u", "Voluptas laudantium aperiam." },
                    { "cgxrow1l", "g72hi9zv", "Odio quaerat eligendi dolorum debitis et et enim omnis." },
                    { "dklyndi4", "60p65c3w", "Voluptatem culpa necessitatibus assumenda qui velit earum aliquam." },
                    { "dqhva5cz", "fzt7e7zn", "Tempore deserunt ea aut consectetur." },
                    { "ecz1hrwd", "qvkh0ni6", "Rerum quis sequi velit temporibus nobis necessitatibus." },
                    { "ejjd5u3h", "vio0a6ca", "Officiis dicta esse alias tenetur ex laborum animi." },
                    { "em2byw9x", "4okmbjij", "Incidunt et provident labore error." },
                    { "g2u0bnwa", "9g1lfd58", "Eligendi quasi mollitia enim ea atque ea est architecto." },
                    { "guvpk3yj", "or9tmp6e", "Est sint ipsum officia dolores quia." },
                    { "h15a0fm6", "cn6lanoq", "Veritatis omnis numquam." },
                    { "hkxy899d", "w6akzbe3", "Cupiditate autem consequatur quos perferendis dicta est rerum dicta et." },
                    { "hojw1ts9", "2lvw1vo2", "Minima ipsa minima repellendus quae soluta dolorem sunt aut quasi." },
                    { "i8pmg5lg", "sm34pnod", "Omnis aspernatur molestiae tenetur voluptate voluptas quia voluptatibus accusamus pariatur." },
                    { "inpinp91", "ztn205x0", "Velit vel veritatis doloribus nisi." },
                    { "iqet3nqn", "qbsxjti4", "Facere voluptatem rem." },
                    { "j860w4g4", "cmapkugk", "Laboriosam quo asperiores dolorum vel ut quod." },
                    { "ja6nmke5", "5x3zyrzm", "Perspiciatis sit mollitia voluptatum dicta soluta dolorem inventore." },
                    { "jqhzmbyx", "zprnkkpv", "Autem laboriosam numquam quia veniam mollitia dicta." },
                    { "kerik1fm", "xdtw1ux7", "Facere et tenetur vel quia." },
                    { "khbdthe2", "ofi5hmkd", "Asperiores non velit expedita fugiat et." },
                    { "ktw1foqz", "zndnnebf", "Expedita quis molestiae voluptate molestiae." },
                    { "kup2fxjo", "qsgdl85x", "Corporis at ullam vel explicabo consectetur exercitationem dolor." },
                    { "kvty95nz", "mae4147w", "Doloribus consequatur a sit quo et." },
                    { "l6op9bdv", "zkzj7ezp", "Maiores odio laudantium suscipit facilis atque accusantium dolorem tempore." },
                    { "lbo0b816", "211v62dk", "Eum ut veniam corporis ut cum voluptatem qui voluptate sunt." },
                    { "llo7gejk", "1pxh9xpi", "Eligendi nihil similique." },
                    { "lrc6jgay", "ty6k75xr", "Magnam ad eaque vel a labore delectus vel." },
                    { "lxj8p30w", "pou1llp5", "Praesentium dolores est qui dolorum ut sequi accusamus temporibus voluptatem." },
                    { "m96h2l4x", "p5gne2t7", "Expedita doloremque est aliquam harum voluptates adipisci reiciendis." },
                    { "ml6bgcrn", "fjlvalom", "Velit nisi dignissimos." },
                    { "mq7m1rgd", "zrzvg64n", "Rerum et harum delectus at molestias mollitia nulla est." },
                    { "mrezxsri", "5hd788p7", "Dicta corporis et voluptatem possimus quasi." },
                    { "mrtvfoe6", "sjivmrnq", "Reiciendis architecto sed iste non cum ipsa porro." },
                    { "p6ponwmc", "jtekdzbo", "Voluptas cumque aut at repudiandae voluptas sed." },
                    { "p7tr8h9u", "46smhh98", "Quia atque et quasi ratione sint qui quod." },
                    { "p9cghgev", "rxy1jqzw", "Sequi repudiandae nihil dolorem rem nam." },
                    { "q3vne2kr", "3cmcj7sm", "Qui inventore cumque explicabo ut atque sapiente aut modi." },
                    { "q3w3nmre", "dhoutsim", "Quia perferendis eos blanditiis." },
                    { "q44bkh9n", "rc1kjo6x", "Est est sed nesciunt magni." },
                    { "qo9evps4", "zrtusf2o", "In accusantium voluptate eius explicabo suscipit sint soluta perferendis." },
                    { "qu4kpfj5", "bmsl6x38", "Praesentium ut et non rerum eos et." },
                    { "r9fj90gs", "buqnp3nb", "Delectus deleniti voluptatem id aperiam molestias dolore enim at." },
                    { "r9ljigki", "5vgoilgq", "Quo vel et quia esse at." },
                    { "rf3kxaz4", "1yicxtws", "Velit dolorum voluptates sunt aliquam fuga velit culpa maxime." },
                    { "rnu9hker", "n5z40vmq", "Quae sit consequatur earum ex iste magni." },
                    { "rr7yb4pj", "7wkjk9wf", "Quos sint repellendus iste qui odio ad culpa eius." },
                    { "sc9ln94n", "a2ni4n25", "Quis quia quo soluta iure consequatur." },
                    { "slee3mvu", "klxeg3fi", "Molestiae autem nam maiores fuga magni veritatis et sit." },
                    { "sue3y1c9", "4a0fij9n", "Dolorum officia ad." },
                    { "twxq25r5", "a15x99ql", "Earum rem aut ipsam impedit recusandae dolorum at voluptatem sunt." },
                    { "u8qpmf9c", "wz60m05z", "Dolorem dolorem rerum omnis asperiores qui rem totam in." },
                    { "ua11hokd", "87xer607", "Autem ex odio saepe a vitae voluptas recusandae." },
                    { "ublorxbt", "h3dx0ykb", "Corrupti maxime delectus cumque iure illo quod asperiores." },
                    { "vbv00azk", "d4rsn5at", "Magni voluptatibus quia." },
                    { "wf1erreq", "jxea5uwg", "Hic suscipit consequatur facilis amet omnis." },
                    { "wtrobuva", "plupm89k", "Veritatis vel quo quibusdam id quia." },
                    { "y2sc6r47", "v1b5lm9t", "Labore maxime minima velit vero magni culpa assumenda veniam." },
                    { "yg1awpd7", "bol7clra", "Beatae perferendis ut qui exercitationem dolor a." },
                    { "yms8nmon", "usqmmtod", "Exercitationem et dolores illo odio magni." },
                    { "yyh4bvtf", "w6cejot7", "Qui perferendis quo odio." },
                    { "yzgbvjx6", "sw47axcz", "Explicabo consequatur eligendi libero voluptatibus deleniti." },
                    { "zgsp3lsv", "1ny4yam8", "Autem expedita qui." },
                    { "zrwxkv0i", "2wwh9syt", "Commodi et quis culpa." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Entities");
        }
    }
}
