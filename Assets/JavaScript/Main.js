window.SetFocusToElement = (element) => {
    element.focus();
};

window.RemoveFocusToElement = (element) => {
    element.blur();
};

function openLayers() {
    const openLayersScript = document.createElement('script');
    openLayersScript.src = '/Assets/JavaScript/ol.js';
    openLayersScript.onload = () => {
        onloadOpenLayers();
    };
    document.body.appendChild(openLayersScript);
}

function onloadOpenLayers() {
    const longitude = 11.107192;
    const latitude = 59.260573;

    let map = new ol.Map({
        target: 'map',
        layers: [
            new ol.layer.Tile({
                source: new ol.source.OSM()
            })
        ],
        view: new ol.View({
            center: ol.proj.fromLonLat([longitude, latitude]),
            zoom: 14
        })
    });

    let marker = new ol.Feature({
        geometry: new ol.geom.Point(ol.proj.fromLonLat([longitude, latitude]))
    });

    let vectorSource = new ol.source.Vector();
    let vectorLayer = new ol.layer.Vector({
        source: vectorSource
    });
    vectorSource.addFeature(marker);
    map.addLayer(vectorLayer);

    let markerStyle = new ol.style.Style({
        image: new ol.style.Icon({
            anchor: [0.38, 1],
            src: '/Assets/Images/map-marker.svg'
        })
    });
    marker.setStyle(markerStyle);

    window.addEventListener('resize', function () {
        map.updateSize();

        let extent = map.getView().calculateExtent(map.getSize());
        map.getView().fit(extent, {size: map.getSize()});
    });
}