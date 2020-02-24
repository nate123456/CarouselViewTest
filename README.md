# CarouselViewTest
This project is just a demo to test Binding features and reproduce bugs with CarouselView and iOS in Xamarin 4. 

# CarouselView CurrentItem cannot be set from ViewModel Bug
To reproduce this bug, run the app on iOS and click the next button. The view will jump for one frame to the next item then immediately back.

# CarouselView CurrentItem is null on first load
To reproduce this bug, checkout branch CurrentItemNullOnFirstLoad and run the app on iOS.

Run the application. The view displays nothing for the CurrentItem property indicating that the value is null.
