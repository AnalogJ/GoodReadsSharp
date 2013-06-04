GoodReadsSharp
==============

## Synopsis

GoodReadsSharp is a C# client library for the GoodReads API. 

## Client Example

    String goodreadsKey = ConfigurationManager.AppSettings["Auth_GoodreadsClient_Key"];
    String goodreadsSecret = ConfigurationManager.AppSettings["Auth_GoodreadsClient_Secret"];
    GoodReadsClient client = new GoodReadsClient(goodreadsKey, goodreadsSecret, goodreadsToken.AccessToken, goodreadsToken.AccessTokenSecret);
    client.ListShelves();

## Motivation

There is currently no C# library for the [GoodReads API](http://www.goodreads.com/api/), atleast none that I could find, so I built one. 

## Installation

The library should be included in your project and referenced as you would any client library. A GoodReads API Key and Secret are required, you can get both here: [GoodReads Api Key](http://www.goodreads.com/api/keys) 

## API Reference
GoodReadsSharp is built off of the RestSharp library, and follows the structure of the [DropNet Project](https://github.com/dkarzon/DropNet/). 
The [GoodReads API](http://www.goodreads.com/api/) is [not very consistent](https://coderwall.com/p/u5o65a). 

Only the API's related to the Owned Books, Account, and Bookshelf are actually available. Events, Groups and Author API's are currently not implemented. 

    public ListOwnedBooks ListOwnedBooks(Int32 page = 1)  
    public AddToOwnedBooks AddToOwnedBooks(String bookId)
    public ListShelves ListShelves(Int32 page = 1)
    public void AddShelf(String shelfName)
    public void DeleteShelf(String shelfId)
    public Shelf AddBookToShelf(String shelfName, String bookId)
    public Hash RemoveBookFromShelf(String shelfName, String bookId)
    public ListBooksOnShelf ListBooksOnShelf(String shelfName, Int32 page = 1)
    public AuthUser AccountInfo()
    public void BookIdForIsbn(String isbn)
    public ReviewCountsForIsbns ReviewCountsForIsbns(List<String> isbns)
    
    public UserLogin GetToken()
    public UserLogin GetAccessToken()


## Contributors

Feel free to contribute to the API. As I said above, the Events, Group and Author API's are currently not implemented. 

## License

Released under the MIT license. 
