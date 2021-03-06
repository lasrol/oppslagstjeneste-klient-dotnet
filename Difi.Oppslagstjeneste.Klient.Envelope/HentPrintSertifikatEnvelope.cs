﻿
using Difi.Oppslagstjeneste.Klient.Felles.Envelope;

namespace Difi.Oppslagstjenesten.Envelope
{
    public class HentPrintSertifikatEnvelope : OppslagstjenesteEnvelope
    {
        public HentPrintSertifikatEnvelope(OppslagstjenesteInstillinger instillinger) : base(instillinger)
        {
        }

        protected override System.Xml.XmlElement CreateBody()
        {
            var body = base.CreateBody();
            var element = Document.CreateElement("ns", "HentPrintSertifikatForespoersel", Navnerom.krr);
            body.AppendChild(element);
            return body;
        }
    }
}
