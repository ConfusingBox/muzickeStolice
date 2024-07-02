﻿using muzickeStolice.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace muzickeStolice.Controller
{
    static public class OsobaController
    {
        static private List<Osoba> _data = new List<Osoba>();

        static private int GenerateID()
        {
            for (int i = 0; ; i++)
            {
                bool taken = false;
                foreach (Osoba b in _data)
                    if (b.ID == i)
                    {
                        taken = true;
                        break;
                    }
                if (!taken)
                    return i;
            }
        }

        static public Osoba? Read(int id)
        {
            foreach (Osoba o in _data)
                if (o.ID == id)
                    return o;
            return null;
        }

        static public Osoba Create(string ime, string prezime, string biografija, DateOnly datumRodjenja)
        {
            Osoba o = new Osoba(GenerateID(), ime, prezime, biografija, datumRodjenja);
            _data.Add(o);
            return o;
        }

        static public void Update(int id, Osoba o2)
        {
            Osoba? o = Read(id);
            if (o == null)
                return;

            o.Ime = o2.Ime;
            o.Prezime = o2.Prezime;
            o.Biografija = o2.Biografija;
            o.DatumRodjenja = o2.DatumRodjenja;
        }

        static public void Delete(int id)
        {
            Osoba? o = Read(id);
            if (o == null)
                return;
            _data.Remove(o);
        }
    }
}