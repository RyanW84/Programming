using GuestBookDemo;

GuestLogic.WelcomeMessage();

var (guests, totalGuests)= GuestLogic.GetAllGuests();//tuple

GuestLogic.DisplayGuests(guests);

GuestLogic.DisplayGuestCount(totalGuests);
