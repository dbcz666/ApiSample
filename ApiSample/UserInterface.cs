using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hotcakes.CommerceDTO.v1.Client;
using Hotcakes.CommerceDTO.v1;
using Hotcakes.CommerceDTO.v1.Catalog;

namespace ApiSample
{
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*void TermekLekeres(string[] args)
            {
                Console.WriteLine("This is a list of products.");
                Console.WriteLine();

                var url = string.Empty;
                var key = string.Empty;

                if (args.Length > 0)
                {
                    foreach (var arg in args)
                    {
                        url = args[0];
                        key = args[1];
                    }
                }

                if (url == string.Empty) url = "http://20.234.113.211:8089";
                if (key == string.Empty) key = "1-0122fcb1-08c3-4c44-8b75-536a2245b3e5";

                var proxy = new Api(url, key);

                var snaps = proxy.ProductsFindAll();
                if (snaps.Content != null)
                {
                    Console.WriteLine("Found " + snaps.Content.Count + " products");
                    Console.WriteLine("-- Products --");
                    for (var i = 0; i < snaps.Content.Count; i++)
                    {
                        if (i < snaps.Content.Count)
                        {
                            Console.WriteLine(i + ") " + snaps.Content[i].ProductName + "| bvin: [" + snaps.Content[i].Bvin + "]");*/
                            /*var cat = proxy.ProductsFind(snaps.Content[i].Bvin);
                            if (cat.Errors.Count > 0)
                            {
                                foreach (var err in cat.Errors)
                                {
                                    Console.WriteLine("ERROR: " + err.Code + " " + err.Description);
                                }
                            }
                            else
                            {
                                Console.WriteLine("By Bvin: " + cat.Content.ProductName + " | " + cat.Content.UrlSlug);
                            }*/

                            //var productSlug = proxy.CategoriesFindBySlug(snaps.Content[i].RewriteUrl);
                            /*if (productSlug.Errors.Count > 0)
                            {
                                foreach (var err in productSlug.Errors)
                                {
                                    Console.WriteLine("ERROR: " + err.Code + " " + err.Description);
                                }
                            }
                            else
                            {
                                Console.WriteLine("By Slug: " + cat.Content.Name + " | " + cat.Content.Description);
                            }*/
                       /* }
                    }
                }

                Console.WriteLine("Done - Press a key to close this window");
                Console.ReadKey();
            }
            
            string[] param = {"x", "y"};
            TermekLekeres(param);*/
        }
    }
}
