using Microsoft.AspNetCore.Mvc;

namespace tpmodul9_1302213019.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Mahasiswa : ControllerBase
    {
        public static List<Mahasiswa1> DataMahasiswa = new List<Mahasiswa1>
        {
            new Mahasiswa1 ("Z", "1302213178"),
            new Mahasiswa1 ("Salasabillah","130221389"),
            new Mahasiswa1 ("Salma", "1302213007"),
            new Mahasiswa1 ("Salwa", "1302210094"),
            new Mahasiswa1 ("Carissa", "1302210027"),
            new Mahasiswa1 ("Aulia", "1302210113")

        };
        //GET: api/<Mahasiswa2>
        [HttpGet]
        public IEnumerable<Mahasiswa1> Get()
        {
            return DataMahasiswa;
        }

        // GET api/<Mahasiswa2>/5
        [HttpGet("{id}")]
        public Mahasiswa1 Get(int id)
        {
            if (id < 0 || id >= DataMahasiswa.Count)
            {
                NotFound();
            }
            return DataMahasiswa[id];
        }

        // POST api/<Mahasiswa2>
        [HttpPost]
        public void Post([FromBody] Mahasiswa1 value)
        {
            DataMahasiswa.Add(value);
        }

        // DELETE api/<Mahasiswa2>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            if (id < 0 || id >= DataMahasiswa.Count)
            {
                NotFound();
            }
            DataMahasiswa.RemoveAt(id);
        }
    }
}