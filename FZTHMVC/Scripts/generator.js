// helpers
String.prototype.toIdFormat = function () {
    return "#" + this;
};
String.prototype.toClassFormat = function () {
    return "." + this;
};

function generateTable(container, initialHotels) {
	var constants = {
        TABLE_ROW_CLASS: 'table-row',
        HOTEL_ADD_CLASS: 'hotel-add',
        HOTEL_UPDATE_CLASS: 'hotel-update',
        HOTEL_DELETE_CLASS: 'hotel-delete',
        ROW_ADD_MODE_CLASS: 'row-hotel-add',
        ROW_UPDATE_MODE_CLASS: 'row-hotel-update',
        ROW_CONFIRM_CLASS: 'row-confirm',
        ROW_CANCEL_CLASS: 'row-cancel'
    };
    var hotels = initialHotels;
    var tableContainer;
    init();

    function init() {
        container.empty();

        tableContainer = $('<table/>')
        container.append(tableContainer);
		
		addButtons();
		initEvents();
		
		generateTableContent();
    }
	
	function refresh() {
        tableContainer.empty();
        generateTableContent();
    }

    function addTableHeaderRow() {
        var headerRowHtml = '<tr>' +
			'<th>Name</th>' +
			'<th>Address</th>' +
			'<th>City</th>' +
			'<th>Rooms</th>' +
			'<th>Stars</th>' +
			'</tr>';

        var headerRow = $(headerRowHtml);
        tableContainer.append(headerRow);
    }

    function generateTableContent() {
        addTableHeaderRow();

        for (var i = 0; i < hotels.length; i++) {
            var hotel = hotels[i];

            var row = $('<tr/>', {
                'data-id': hotel.id
            });

            addTextTableCellToRow(row, hotel.name);
            addTextTableCellToRow(row, hotel.address);
            addTextTableCellToRow(row, hotel.city);
            addTextTableCellToRow(row, hotel.rooms);
            addTextTableCellToRow(row, hotel.stars);

			addOperationsCellToRow(row);

            tableContainer.append(row);
        }
    }

    function addTextTableCellToRow(row, text) {
        var cellToAdd = $('<td/>', {
            text: text
        });
        row.append(cellToAdd);
    }
	
	function addOperationsCellToRow(row) {
        var hotelEditButton = $('<button/>', {
            'class': constants.HOTEL_UPDATE_CLASS,
            'text': 'Edit'
        });

        row.append(hotelEditButton);

        var hotelDeleteButton = $('<button/>', {
            'class': constants.HOTEL_DELETE_CLASS,
            'text': 'Delete'
        });

        row.append(hotelDeleteButton);
    }
	
	function addTextControlCellToRow(row, controlRole, value) {
        var control = $('<input/>', {
            'type': 'text',
            'data-crole': controlRole,
            'value': value
        });

        var cell = $('<td/>');
        cell.append(control);

        row.append(cell);
    }
	
	function addOperationsCellToRowForAddUpdate(row) {
        var cell = $('<td/>');
        var hotelConfirmButton = $('<button/>', {
            'class': constants.ROW_CONFIRM_CLASS,
            'text': 'Confirm'
        });

        cell.append(hotelConfirmButton);

        var hotelCancelButton = $('<button/>', {
            'class': constants.ROW_CANCEL_CLASS,
            'text': 'Cancel'
        });

        cell.append(hotelCancelButton);

        row.append(cell);
     }

     function getControlValueFromRowByRole(row, controlRole) {
         var matchedControls = row.find('input[data-crole="' + controlRole + '"]');        
         var matchedControlValue = null;
         
         if (matchedControls.length > 0) {
             var matchedControl = null;
             matchedControl = $(matchedControls[0]);

             matchedControlValue = matchedControl.val();
         }

         return matchedControlValue;
     }

     function mapRowToHotel(row) {
         var hotelId = row.data('id');

         var hotel = {
             id: hotelId,
             name: getControlValueFromRowByRole(row, 'name'),
             address: getControlValueFromRowByRole(row, 'address'),
             city: getControlValueFromRowByRole(row, 'city'),
             rooms: getControlValueFromRowByRole(row, 'rooms'),
             stars: getControlValueFromRowByRole(row, 'stars')
         };

         return hotel;
     }
	
	function addButtons() {
        var hotelAddButton = $('<button/>', {
            'class': constants.HOTEL_ADD_CLASS,
            'text': 'Add new hotel'
        });

        container.append(hotelAddButton);
    }
	
	function initEvents() {
        container.on('click', constants.HOTEL_ADD_CLASS.toClassFormat(), function () {
            onHotelAdd(this);
        });
        container.on('click', constants.HOTEL_UPDATE_CLASS.toClassFormat(), function () {
            onHotelUpdate(this);
        });
        container.on('click', constants.HOTEL_DELETE_CLASS.toClassFormat(), function () {
            onHotelDelete(this);
        });

        container.on('click', constants.ROW_CONFIRM_CLASS.toClassFormat(), function () {
            onOperationConfirm(this);
        });
        container.on('click', constants.ROW_CANCEL_CLASS.toClassFormat(), function () {
            onOperationCancel(this);
        });
    }
	
	function onHotelAdd(sender) {
        console.log('onHotelAdd'); 
        enterAddMode();
    }

     function onHotelUpdate(sender) {
        console.log('onHotelUpdate');

        var row = $(sender).closest('tr');
        var hotelId = row.data('id');

        var hotelToUpdate = getHotelById(hotelId);
        enterUpdateMode(hotelToUpdate);
    }

     function onHotelDelete(sender) {
        console.log('onHotelDelete');
		
		var row = $(sender).closest('tr');
        var hotelId = row.data('id');
		var hotelToRemove = getHotelById(hotelId);
		
		if(hotelToRemove != null) {
			var userHasConfirmedAction = confirm('Are you sure you want to delete the selected hotel (' + hotelToRemove.name + ')?');
			if(userHasConfirmedAction === true) {
				removeHotel(hotelToRemove.id);
				refresh();
			}
		}
    }

    function onOperationConfirm(sender) {
        console.log('onOperationConfirm');


        var row = $(sender).closest('tr');
        var hotelFromRow = mapRowToHotel(row);

        var mustAddHotel = row.hasClass(constants.ROW_ADD_MODE_CLASS);
        if (mustAddHotel) {
            var maxHotelId = getMaxHotelId();
            var newHotelId = maxHotelId + 1;

            hotelFromRow.id = newHotelId;

            addHotel(hotelFromRow);
        } else {
            updateHotel(hotelFromRow);
        }

        refresh();
    }

    function onOperationCancel(sender) {
        console.log('onOperationCancel');
        refresh();
    }


     function enterAddMode() {
        var row = $('<tr/>', {
            'class': constants.ROW_ADD_MODE_CLASS
        });

        addTextControlCellToRow(row, 'name');
        addTextControlCellToRow(row, 'address');
        addTextControlCellToRow(row, 'city');
        addTextControlCellToRow(row, 'rooms');
        addTextControlCellToRow(row, 'stars');
        
        addOperationsCellToRowForAddUpdate(row);

        var headerRow = tableContainer.find('tr')[0];
        $(headerRow).after(row);
    }

     function enterUpdateMode(hotel) {
        var row = $('<tr/>', {
            'class': constants.ROW_UPDATE_MODE_CLASS,
        });

        addTextControlCellToRow(row, 'name', hotel.name);
        addTextControlCellToRow(row, 'address', hotel.address);
        addTextControlCellToRow(row, 'city', hotel.city);
        addTextControlCellToRow(row, 'rooms', hotel.rooms);
        addTextControlCellToRow(row, 'stars', hotel.stars);
        
        addOperationsCellToRowForAddUpdate(row);

        var rowToUpdate = tableContainer.find('tr[data-id="' + hotel.id + '"]');
        rowToUpdate.html(row.html());
    }
	
	// hotel operations
    
    function getHotelById(id) {
        var associatedHotel = null;

        $.each(hotels, function(hotelIndex, hotel) {
            if(hotel.id == id) {
                associatedHotel = hotel;
                return false;
            }
        });

        return associatedHotel;
    }   

    function getMaxHotelId() {
        var maxHotelId = 1;

        $.each(hotels, function (hotelIndex, hotel) {
            var currentHotelId = parseInt(hotel.id);
            if (currentHotelId > maxHotelId) {
                maxHotelId = currentHotelId;
            }
        });

        return maxHotelId;
    }

      function addHotel(hotel) {
        hotels.push(hotel);
    }

	function updateHotel(hotel) {
        var positionToUpdate = null;
        var index;

        // find the postion in the hotels array of the object that needs to be updated
        for (index = 0; index < hotels.length; index++) {
            var currentHotel = hotels[index];
            if (currentHotel.id == hotel.id) {
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
	for(index = 0; index < hotels.length; index++) {
		var currentHotel = hotels[index];
		if(currentHotel.id === hotelId) {
			positionToRemove = index;
			
			// the position was found so we don't need to search the rest of the array
			break;
		}
	}
	
	if(positionToRemove != null) {
		// the given hotel exists already, so remove it from the array
		hotels.splice(positionToRemove, 1)
	} else {
		// the given hotel doesn't exist in the array, so we can throw an error or simply do nothing
		// we choose to simply do nothing
	}
}
};

















