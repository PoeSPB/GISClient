using GISClient.Data.Model;
using GISClient.Pages;
using System.Linq;

namespace GISClient.Data.Service
{
    public class TestData
    {
        public List<GeoObjectDTO> GetGeoObjects()
        {
            List<GeoObjectDTO> geoObjects = new List<GeoObjectDTO>();

            GeoNamesFeatureDTO bldg = new GeoNamesFeatureDTO()
            {
                GeoNamesFeatureCode = "BLDG"
            };

            // микрорайон дефолт
            GeoObjectDTO area1 = new GeoObjectDTO()
            {
                Name = "Микрорайон_дефолт",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[60.00723625, 30.22990990], [60.00795076, 30.23026931], [60.00764991, 30.23266721], [60.00725505, 30.23251700], [60.00720402, 30.23272085], [60.00655128, 30.23240972], [60.00670976, 30.23088622], [60.00703479, 30.23092377]]"
                },
                GeoNameFeature = new GeoNamesFeatureDTO()
                {
                    GeoNamesFeatureCode = "DEVH"
                }
            };

            // бонч
            GeoObjectDTO area2 = new GeoObjectDTO()
            {
                Name = "СПБГУТ",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[59.903876, 30.489583], [59.903306, 30.486958], [59.901707, 30.488379], [59.902345, 30.491153]]"
                },
                GeoNameFeature = new GeoNamesFeatureDTO()
                {
                    GeoNamesFeatureCode = "DEVH"
                }
            };

            // микрорайон №3
            GeoObjectDTO area3 = new GeoObjectDTO()
            {
                Name = "Микрорайон",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[59.890919, 30.491236], [59.890220, 30.491060], [59.890164, 30.492179], [59.890864, 30.492316]]"
                },
                
                GeoNameFeature = new GeoNamesFeatureDTO()
                {
                    GeoNamesFeatureCode = "DEVN"
                }
            };

            // метро на сенной
            GeoObjectDTO metro = new GeoObjectDTO()
            {
                //Name = "Метро Сенная-Садовая-Спасская",
                 Name = "Метро Сенная-Садовая",

                Geometry = new GeometryVersionDTO()
                {
                     BorderGeocodes = "[ [59.927225, 30.317554], [59.926874, 30.316653], [59.926276, 30.318000], [59.927052, 30.319973], [59.926786, 30.320394] ,[59.927029, 30.320828], [59.927348, 30.320319], [59.926657, 30.318504] ]"
                    // BorderGeocodes = "[ [59.927225, 30.317554], [59.926874, 30.316653], [59.926276, 30.318000],[59.926726, 30.319338], [59.926467, 30.319785], [59.926748, 30.320452] , [59.926787, 30.320414], [59.927029, 30.320828], [59.927348, 30.320319], [59.926657, 30.318504] ]"
                }, 
                GeoNameFeature = new GeoNamesFeatureDTO()
                {
                    GeoNamesFeatureCode = ""
                }
            };


            TopologyLinkDTO topologyLink1 = new TopologyLinkDTO() { Predicate = "212101212" };
            GeoObjectDTO geoObject1 = new GeoObjectDTO()
            {
                Name = "Объект 1",
                Geometry = new GeometryVersionDTO() { 
                    BorderGeocodes = "[[60.00715567, 30.23072529], [60.00725122, 30.23003404], [60.00790394, 30.23036663], [60.00787708, 30.23057584], [60.00733449, 30.23031299], [60.00727002, 30.23077969]]" 
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO>() {  topologyLink1 },
                OutputTopologyLinks = new List<TopologyLinkDTO>() { topologyLink1 }
            };
            
            GeoObjectDTO geoObject2 = new GeoObjectDTO()
            {
                Name = "Объект 2",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[60.00787708, 30.23057584], [60.00762727, 30.23253922], [60.00717869, 30.23231928], [60.00720018, 30.23209397], [60.00754669, 30.23225491], [60.00776930, 30.23052354]]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO>() { topologyLink1 },
                OutputTopologyLinks = new List<TopologyLinkDTO>() { topologyLink1 }
            };
            GeoObjectDTO geoObject3 = new GeoObjectDTO()
            {
                Name = "Объект 3",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[60.00719437, 30.23239377], [60.00716751, 30.23261371], [60.00661416, 30.23232939], [60.00677533, 30.23100975], [60.00688277, 30.23106339], [60.00674847, 30.23216310]]"
                },
                GeoNameFeature = bldg
            };
            

            TopologyLinkDTO topologyLink2 = new TopologyLinkDTO() { Predicate = "323202323" };
            GeoObjectDTO firstbld = new GeoObjectDTO()
            {
                Name = "Корпус 1",
                Geometry = new GeometryVersionDTO()
                {
                  BorderGeocodes = "[[59.903662127926886,30.488277612784817], [59.90338727996388,30.48855656252219], [59.903247160719715,30.487923561194847], [59.90285105071495,30.488304434874923], [59.90299117180688,30.48891061411229], [59.902735181012915,30.489125190833473], [59.90260044820616,30.488551198104343], [59.90222594490034,30.488899847552695], [59.902357984604045,30.489511391208186], [59.902091210011555,30.48973669676532], [59.901789401789514,30.488358041331647], [59.90332668140502,30.486916006907535] ]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> { topologyLink2 },
                OutputTopologyLinks = new List<TopologyLinkDTO> {topologyLink2 }
                
            };
            GeoObjectDTO secondBld = new GeoObjectDTO()
            {
                Name = "Корпус 2",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[59.9035971,30.4885647], [59.903465126514945,30.48870424587563], [59.90344626436974,30.489047568629523], [59.903610634130736,30.489551823924337], [59.90320877236683,30.48991021845295], [59.903084819970196,30.489379141068007], [59.902966256373816,30.48920747969106], [59.90285038699428,30.489304039215586], [59.90280996734782,30.4896312687154], [59.90297303720917,30.49009208984494], [59.90258231334047,30.49048369236112], [59.902485305320354,30.48997407264828], [59.902337098073986,30.489780953599205], [59.902208226509096,30.489893606377834], [59.90218127956081,30.490231564713703], [59.902435613083455,30.491003817969972], [59.90393254612325,30.489673537308473], [59.90375201055671,30.488804501587637]]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> { topologyLink2 },
                OutputTopologyLinks = new List<TopologyLinkDTO> { topologyLink2 }
            };


            TopologyLinkDTO topologyLink3 = new TopologyLinkDTO() { Predicate = "123404321" };
           

            // Первый вариант

            /* GeoObjectDTO parad1 = new GeoObjectDTO()
            {
                Name = "Корпус А",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[ [59.890518, 30.491239], [59.890267, 30.491171], [59.890246, 30.491517], [59.890493, 30.491575]]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> {topologyLink3},
                OutputTopologyLinks = new List<TopologyLinkDTO> {topologyLink3}
            };
            GeoObjectDTO parad2 = new GeoObjectDTO()
            {
                Name = "Корпус В",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[59.890518, 30.491239], [59.890493, 30.491575], [59.890668, 30.491618], [59.890667, 30.491642], [59.890770, 30.491662], [59.890794, 30.491294]]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> { topologyLink3 },
                OutputTopologyLinks = new List<TopologyLinkDTO> { topologyLink3 }
            };*/
            GeoObjectDTO parad12 = new GeoObjectDTO()
            {
                Name = "Корпус 1",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[59.890789, 30.491293], [59.890261, 30.491159], [59.890240, 30.491491], [59.890670, 30.491595], [59.890669, 30.491646], [59.890764, 30.491662]]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> { topologyLink3 },
                OutputTopologyLinks = new List<TopologyLinkDTO> { topologyLink3 }
            };



            GeoObjectDTO parad3 = new GeoObjectDTO()
            {
               // Name = "Корпус С",
                Name = "Корпус 1а",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[59.890681, 30.491642], [59.890822, 30.491679], [59.890796, 30.492150], [59.890641, 30.492116] ]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> { topologyLink3 },
                OutputTopologyLinks = new List<TopologyLinkDTO> { topologyLink3 }
            };

            TopologyLinkDTO topologyLink4 = new TopologyLinkDTO() { Predicate = "111454111" };

            GeoObjectDTO St_sen = new GeoObjectDTO()
            {
                Name = "Ст. Сенная площадь",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[ [59.927213, 30.320480], [59.927052, 30.320099], [59.926954, 30.320278], [59.926878, 30.320268], [59.926859, 30.320490], [59.926971, 30.320528], [59.927060, 30.320742]]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4 },
                OutputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4 }
            };

            GeoObjectDTO Sad1 = new GeoObjectDTO()
            {
                Name = "Ст. Садовая вход 1",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[59.926356, 30.317910], [59.926306, 30.317993], [59.926376, 30.318154], [59.926421, 30.318077]]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> {topologyLink4},
                OutputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4}
            };

            GeoObjectDTO Sad2 = new GeoObjectDTO()
            {
                Name = "Ст. Садовая вход 2",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[[59.926629, 30.318554], [59.926556, 30.318383], [59.926510, 30.318470], [59.926583, 30.318640]]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4 },
                OutputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4 }
            };

            GeoObjectDTO Sad3 = new GeoObjectDTO()
            {
                Name = "Ст. Садовая вход3", 
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[ [59.926943, 30.316893], [59.926872, 30.316726], [59.926825, 30.316805], [59.926894, 30.316969] ]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4}, 
                OutputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4}
            };

            GeoObjectDTO Sad4 = new GeoObjectDTO()
            {
                Name = "Ст. Садовая вход4",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[ [59.927219, 30.317552], [59.927150, 30.317390], [59.927106, 30.317470], [59.927172, 30.317632] ]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4 },
                OutputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4 }
            };

            GeoObjectDTO Sp = new GeoObjectDTO()
            {
                Name = "Ст. Спасская",
                Geometry = new GeometryVersionDTO()
                {
                    BorderGeocodes = "[ [59.926979, 30.319995], [59.926726, 30.319386], [59.926501, 30.319753], [59.926707, 30.320287], [59.926793, 30.320311] ]"
                },
                GeoNameFeature = bldg,
                InputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4 },
                OutputTopologyLinks = new List<TopologyLinkDTO> { topologyLink4 }
            };

            geoObjects.Add(area1);
            geoObjects.Add(area2);
            geoObjects.Add(area3);
            geoObjects.Add(metro);
            geoObjects.Add(geoObject1);
            geoObjects.Add(geoObject2);
            geoObjects.Add(geoObject3);
            geoObjects.Add(secondBld);
            geoObjects.Add(firstbld);
            // geoObjects.Add(parad1);
            // geoObjects.Add(parad2);
            geoObjects.Add(parad12);
            geoObjects.Add(parad3);
            geoObjects.Add(St_sen);
            geoObjects.Add(Sad1);
            geoObjects.Add(Sad2);
            geoObjects.Add(Sad3);
            geoObjects.Add(Sad4);
            //geoObjects.Add(Sp);
            return geoObjects;
        }
    }
}
