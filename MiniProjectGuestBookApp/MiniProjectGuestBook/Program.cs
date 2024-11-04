using MiniProjectGuestBook;

//Greet the User
BookingLogic.WelcomeUser();

(List<string> guests, int totalGuests) = BookingLogic.GetAllGuests();

BookingLogic.DisplayGuests(guests);

BookingLogic.DisplayGuestCount(totalGuests);