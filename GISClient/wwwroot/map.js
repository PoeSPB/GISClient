function renderYandexMap(objects) {
    ymaps.ready(
        function initMap() {
            var mapElement = document.getElementById("map");
            mapElement.innerHTML = '';
            var map = new ymaps.Map(mapElement, {
                //center: [60.00729266, 30.23136365], // дефолт дом
                //center: [59.902824, 30.489140], // бонч
                // center: [59.890521, 30.491702], // микрорайон №2
                center: [59.926810, 30.317892], // метро Адмиралтейства
                zoom: 17,
                type: 'yandex#satellite',
                controls: ['zoomControl']
            });
            drawGeoObjects(map, objects);
        }
    )
}
function drawGeoObjects(map, objects) {
    objects.forEach(e => {
        var polygon = new ymaps.Polygon([
            JSON.parse(e.geometry.borderGeocodes)
        ], {
            hintContent: e.name
        }, {
            fillColor: e.geoNameFeature.geoNamesFeatureCode === 'BLDG' ? 'rgba(224,143,0,0.53)' : 'rgba(0,122,222,0.53)',
            
            strokeColor: e.geoNameFeature.geoNamesFeatureCode === 'BLDG' ? 'rgba(204,76,3,0.53)' : 'rgba(0,40,206,0.53)',
            strokeWidth: e.geoNameFeature.geoNamesFeatureCode === 'BLDG' ? 3 : 2
        });
        map.geoObjects.add(polygon);
    })
}