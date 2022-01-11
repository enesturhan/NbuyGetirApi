using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NbuyGetir.Core.Caching
{
    
    /// <summary>
    /// getir utgulamasındaki kategorleri ve bu kategorilere ait alt kategori bilgisni cacheden yani ram üzerinden okuyacagız. Böylece her seferinde dbden cekmedigimiz icin daha hızlı bir sonuc donudrüceğiz. Bu gibi cok fazla crud operasyonunu yapılmadıgı sınıflarımızı ramden okuyaiblir. Aynı zamanda sepet gibi islemelr icinde tanımlanabilri. Çok fazla insert update islemi olmayan verilerimiz için cache mekanizması kullanırız. 
    /// </summary>
    public interface ICacheService<TResult> where TResult : class
    {
        void SetCache(string key,TResult cacheData);
        TResult GetFromCache(string key);

    }
}
