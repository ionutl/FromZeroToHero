function Hotel(hotel) {
    this.id = hotel.id;
    this.name = hotel.name;
    this.address = hotel.address;
    this.city = hotel.city;
    this.rooms = hotel.rooms;
    this.stars = hotel.stars;
}

var hotels = [
	new Hotel({ id: 1, name: 'Hotel 1', address: 'Hotel 1 description', city: 'City 1', rooms: 30, stars: 4 }),
	new Hotel({ id: 2, name: 'Hotel 2', address: 'Hotel 2 description', city: 'City 2', rooms: 10, stars: 1 }),
	new Hotel({ id: 3, name: 'Hotel 3', address: 'Hotel 3 description', city: 'City 3', rooms: 25, stars: 2 }),
	new Hotel({ id: 4, name: 'Hotel 4', address: 'Hotel 4 description', city: 'City 4', rooms: 1000, stars: 7 }),
	new Hotel({ id: 5, name: 'Hotel 5', address: 'Hotel 5 description', city: 'City 5', rooms: 50, stars: 3 })
];