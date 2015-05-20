// method used to add a hotel into the array
function addHotel(hotel) {
    // we consider that the given hotel doesn't already exist in the array

    // add the given hotel at the end of the hotels array
    hotels.push(hotel);
}

// method used to update a given hotel
function updateHotel(hotel) {
    var positionToUpdate = null;
    var index;

    // find the postion in the hotels array of the object that needs to be updated
    for (index = 0; index < hotels.length; index++) {
        var currentHotel = hotels[index];
        if (currentHotel.id === hotel.id) {
            positionToUpdate = index;

            // the position was found so we don't need to search the rest of the array
            break;
        }
    }

    if (positionToUpdate != null) {
        // the given hotel exists already, so update it with the new one
        hotels[positionToUpdate] = hotel;
    } else {
        // the given hotel doesn't exist in the array, so we can throw an error or simply add it to the list
        // we choose to simply add the object
        hotels.push(hotel);
    }
}

// method used to remove a given hotel
function removeHotel(hotelId) {
    var positionToRemove = null;
    var index;

    // find the postion in the hotels array of the object that needs to be removed
    for (index = 0; index < hotels.length; index++) {
        var currentHotel = hotels[index];
        if (currentHotel.id === hotelId) {
            positionToRemove = index;

            // the position was found so we don't need to search the rest of the array
            break;
        }
    }

    if (positionToRemove != null) {
        // the given hotel exists already, so remove it from the array
        hotels.splice(positionToRemove, 1)
    } else {
        // the given hotel doesn't exist in the array, so we can throw an error or simply do nothing
        // we choose to simply do nothing
    }
}

function showHotelsCountAndLastAdded() {
    var hotelsCount = hotels.length;
    console.log('Number of hotels: ' + hotelsCount);
    if (hotelsCount != 0) {
        console.log('Last added hotel: ' + hotels[hotels.length - 1].name);
    }
}

function getHotelById(hotelId) {
    var associatedHotel = null;

    for (index = 0; index < hotels.length; index++) {
        var currentHotel = hotels[index];
        if (currentHotel.id === hotelId) {
            associatedHotel = currentHotel;

            // the position was found so we don't need to search the rest of the array
            break;
        }
    }

    return associatedHotel;
}

function getMaxHotelId() {
    if (hotels.length == 0) {
        return null;
    }

    var maxHotelId = hotels[0].id;

    for (index = 1; index < hotels.length; index++) {
        var currentHotel = hotels[index];
        var currentHotelId = currentHotel.id;

        if (currentHotelId > maxHotelId) {
            maxHotelId = currentHotelId;
        }
    }

    return maxHotelId;
}

// function used to test the CRUD methods defined above
function testCrudFunctions() {
    var newHotel = new Hotel({
        id: 1,
        name: 'Hotel 2',
        description: 'Hotel 1 description',
        country: 'Country 1',
        city: 'City 1',
        addedDate: new Date(2000, 1, 1),
        startPrice: 11.1
    });
    addHotel(newHotel);

    console.log('After adding a hotel');
    showHotelsCountAndLastAdded();

    newHotel.name = 'Hotel 1';
    updateHotel(newHotel);

    console.log('After updating the hotel');
    showHotelsCountAndLastAdded();

    console.log('After removing the hotel by its id');
    removeHotel(newHotel.id);
    showHotelsCountAndLastAdded();

    addHotel(newHotel);
    var maxHotelId = getMaxHotelId();
    if (maxHotelId != null) {
        var hotelWithMaxId = getHotelById(maxHotelId);
        console.log('The max hotel id is: ' + maxHotelId + ' (' + hotelWithMaxId.name + ')');
    } else {
        console.log('The array is empty');
    }
}

testCrudFunctions();