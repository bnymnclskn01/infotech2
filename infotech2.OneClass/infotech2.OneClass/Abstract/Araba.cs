using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Abstract
{
    public abstract class Araba
    {
        // Arabaların ortak özelliklerini buraya yazıyoruz.
        public string Marka { get; set; }
        public int MaksimumHiz { get; set; }
        public string Tur { get; set; }
        //Her araba için yolculuğa başlandı bilgisini farklı
        //bir şekilde ekrana yazdırmak için override edilecek
        //abstract metodumuzu yazıyoruz
        public abstract void YolculugaBasla();
        //gövdesi olmayan bir metot belirledik.
    }
}
/*
Classlar nesnelerle farklı ortamlara taşınabilir.
Classlar kendi içinde birden fazla kalıtıma uğrayabilir.
Classlar farklı classlarda nesne olarak tanımlandığında
public olmak zorunda.
abstract class public olma zorunluluğu yoktur.
Abstract Class nesne olarak kesinle ve kesinlike
tanımlanamaz.
Classlar için geçerlidir
Tasit tasit=new Tasit();
Interface ve Abstract Class İçin geçerli değildir.
Interface ile abstract class arasındaki fark
Abstract class soyut olan herşeyi yaparsın
Interface sadece govdesiz metot tanımlayarak kabiliyet oluşturuyorduk.
Aynı zamanda
Abstract class için işlemlerde herzaman soyut ifae olması
gerekir.
Çarpışan Araba is a Araba
Interfacelerde kabileyet gerekir
Bu çarpışan araba hızlı gidemez.
 */
