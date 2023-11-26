// See https://aka.ms/new-console-template for more information
using AtomFactory;

IAtom carbonAtom = AFactory.CreateAtom("carbon");
IAtom HydrogenAtom = AFactory.CreateAtom("hydrogen");

HydrogenAtom.DisplayInfo();
carbonAtom.DisplayInfo();
