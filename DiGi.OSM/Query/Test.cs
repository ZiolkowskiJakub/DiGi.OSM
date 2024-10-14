using NetTopologySuite.Geometries;
using OsmSharp.Geo;
using OsmSharp.Geo.Streams;
using OsmSharp.Streams;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DiGi.OSM
{
    public static partial class Query
    {
        public static void Test(string path, long id = 407692677)
        {
            if(string.IsNullOrWhiteSpace(path) || !File.Exists(path))
            {
                return;
            }

            using (FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                OsmStreamSource osmStreamSource = null;

                string extension = Path.GetFileNameWithoutExtension(path);
                if(extension != null && extension.ToUpper().Contains("PBF"))
                {
                    osmStreamSource = new PBFOsmStreamSource(fileStream);
                }
                else
                {
                    osmStreamSource = new XmlOsmStreamSource(fileStream);
                }

                // filter all powerlines and keep all nodes.
                IEnumerable<OsmSharp.OsmGeo> osmGeos = from osmGeo in osmStreamSource where osmGeo.Type == OsmSharp.OsmGeoType.Node || (osmGeo.Type == OsmSharp.OsmGeoType.Way && osmGeo.Tags != null && osmGeo.Id == id) select osmGeo;

                foreach(OsmSharp.OsmGeo osmGeo in osmGeos)
                {
                    IFeatureStreamSource featureStreamSource = osmGeos.ToFeatureSource();

                    // filter out only linestrings.
                    IEnumerable<NetTopologySuite.Features.IFeature> features = from feature in featureStreamSource where feature.Geometry is LineString select feature;
                    foreach (NetTopologySuite.Features.IFeature feature in features)
                    {

                    }
                }


            }
        }
    }
}
