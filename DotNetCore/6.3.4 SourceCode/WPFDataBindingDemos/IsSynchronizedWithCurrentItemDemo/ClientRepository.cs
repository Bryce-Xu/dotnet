using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsSynchronizedWithCurrentItemDemo
{
    /// <summary>
    /// 提供测试用的对象集合
    /// </summary>
    public class ClientRepository
    {
        public static List<Client> GetAllClients()
        {
            List<Client> Clients = new List<Client>();
            int IdCounter = 0;
            IdCounter++;
            Clients.Add(new Client() {
                Name = "王蓝蓝",
                Address = "上海市闵行区鹤庆路560弄77号502室",
            Id = IdCounter
            });
            IdCounter++;
            Clients.Add(new Client()
            {
                Name = "陆瑛",
                Address = "南宁市园湖南路9号接力出版社  编辑一部",
                Id = IdCounter
            });
            IdCounter++;
            Clients.Add(new Client()
            {
                Name = "黄学珍",
                Address = "贵州省高级人民法院财务科",
                Id = IdCounter
            });
            IdCounter++;
            Clients.Add(new Client()
            {
                Name = "陆宁",
                Address = "上海延安西路1228弄2号嘉利大厦31楼J座",
                Id = IdCounter
            });
            IdCounter++;
            Clients.Add(new Client()
            {
                Name = "王建国",
                Address = "山西省大同市新开北路81号大齿集团传动箱分公司",
                Id = IdCounter
            });
            IdCounter++;
            Clients.Add(new Client()
            {
                Name = "张栩",
                Address = "北京市西城区黄寺大街23号阳光丽景2-4-602",
                Id = IdCounter
            });
            IdCounter++;
            Clients.Add(new Client()
            {
                Name = "叶玮池",
                Address = "福建厦门市枋湖西二路5-7号厦门锦江电子有限公司",
                Id = IdCounter
            });
            IdCounter++;
            Clients.Add(new Client()
            {
                Name = "郭楠",
                Address = "辽宁鞍山市铁东区东解放路53-44号",
                Id = IdCounter
            });
            IdCounter++;
            Clients.Add(new Client()
            {
                Name = "黄忠平",
                Address = "江苏无锡市新区科技园四区五楼中顺生物公司",
                Id = IdCounter
            });
            IdCounter++;
            Clients.Add(new Client()
            {
                Name = "陈莉",
                Address = "广州市华景新城华景路粤生街74号405室",
                Id = IdCounter
            });
            return Clients;
        }
    }
}
