﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookStore.BookStoreServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BookStoreServiceReference.IBookStoreService")]
    public interface IBookStoreService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetAllBooks", ReplyAction="http://tempuri.org/IBookStoreService/GetAllBooksResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        object[] GetAllBooks();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/GetAllBooks", ReplyAction="http://tempuri.org/IBookStoreService/GetAllBooksResponse")]
        System.Threading.Tasks.Task<object[]> GetAllBooksAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/addBook", ReplyAction="http://tempuri.org/IBookStoreService/addBookResponse")]
        bool addBook(string[] newBook);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/addBook", ReplyAction="http://tempuri.org/IBookStoreService/addBookResponse")]
        System.Threading.Tasks.Task<bool> addBookAsync(string[] newBook);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/deleteBook", ReplyAction="http://tempuri.org/IBookStoreService/deleteBookResponse")]
        [System.ServiceModel.FaultContractAttribute(typeof(System.Exception), Action="http://tempuri.org/IBookStoreService/deleteBookExceptionFault", Name="Exception", Namespace="http://schemas.datacontract.org/2004/07/System")]
        bool deleteBook(string type, string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/deleteBook", ReplyAction="http://tempuri.org/IBookStoreService/deleteBookResponse")]
        System.Threading.Tasks.Task<bool> deleteBookAsync(string type, string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/searchBook", ReplyAction="http://tempuri.org/IBookStoreService/searchBookResponse")]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(object[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(string[]))]
        [System.ServiceModel.ServiceKnownTypeAttribute(typeof(System.Exception))]
        object[] searchBook(string type, string input);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBookStoreService/searchBook", ReplyAction="http://tempuri.org/IBookStoreService/searchBookResponse")]
        System.Threading.Tasks.Task<object[]> searchBookAsync(string type, string input);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBookStoreServiceChannel : BookStore.BookStoreServiceReference.IBookStoreService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BookStoreServiceClient : System.ServiceModel.ClientBase<BookStore.BookStoreServiceReference.IBookStoreService>, BookStore.BookStoreServiceReference.IBookStoreService {
        
        public BookStoreServiceClient() {
        }
        
        public BookStoreServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BookStoreServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookStoreServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BookStoreServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public object[] GetAllBooks() {
            return base.Channel.GetAllBooks();
        }
        
        public System.Threading.Tasks.Task<object[]> GetAllBooksAsync() {
            return base.Channel.GetAllBooksAsync();
        }
        
        public bool addBook(string[] newBook) {
            return base.Channel.addBook(newBook);
        }
        
        public System.Threading.Tasks.Task<bool> addBookAsync(string[] newBook) {
            return base.Channel.addBookAsync(newBook);
        }
        
        public bool deleteBook(string type, string input) {
            return base.Channel.deleteBook(type, input);
        }
        
        public System.Threading.Tasks.Task<bool> deleteBookAsync(string type, string input) {
            return base.Channel.deleteBookAsync(type, input);
        }
        
        public object[] searchBook(string type, string input) {
            return base.Channel.searchBook(type, input);
        }
        
        public System.Threading.Tasks.Task<object[]> searchBookAsync(string type, string input) {
            return base.Channel.searchBookAsync(type, input);
        }
    }
}
