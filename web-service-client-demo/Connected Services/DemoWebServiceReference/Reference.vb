﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Data

Namespace DemoWebServiceReference
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="DemoWebServiceReference.DemoWebServiceSoap")>  _
    Public Interface DemoWebServiceSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function HelloWorld() As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/HelloWorld", ReplyAction:="*")>  _
        Function HelloWorldAsync() As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/CariListesi", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function CariListesi() As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/CariListesi", ReplyAction:="*")>  _
        Function CariListesiAsync() As System.Threading.Tasks.Task(Of System.Data.DataTable)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/CariHareketListesi", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=true)>  _
        Function CariHareketListesi() As System.Data.DataTable
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/CariHareketListesi", ReplyAction:="*")>  _
        Function CariHareketListesiAsync() As System.Threading.Tasks.Task(Of System.Data.DataTable)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface DemoWebServiceSoapChannel
        Inherits DemoWebServiceReference.DemoWebServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class DemoWebServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of DemoWebServiceReference.DemoWebServiceSoap)
        Implements DemoWebServiceReference.DemoWebServiceSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function HelloWorld() As String Implements DemoWebServiceReference.DemoWebServiceSoap.HelloWorld
            Return MyBase.Channel.HelloWorld
        End Function
        
        Public Function HelloWorldAsync() As System.Threading.Tasks.Task(Of String) Implements DemoWebServiceReference.DemoWebServiceSoap.HelloWorldAsync
            Return MyBase.Channel.HelloWorldAsync
        End Function
        
        Public Function CariListesi() As System.Data.DataTable Implements DemoWebServiceReference.DemoWebServiceSoap.CariListesi
            Return MyBase.Channel.CariListesi
        End Function
        
        Public Function CariListesiAsync() As System.Threading.Tasks.Task(Of System.Data.DataTable) Implements DemoWebServiceReference.DemoWebServiceSoap.CariListesiAsync
            Return MyBase.Channel.CariListesiAsync
        End Function
        
        Public Function CariHareketListesi() As System.Data.DataTable Implements DemoWebServiceReference.DemoWebServiceSoap.CariHareketListesi
            Return MyBase.Channel.CariHareketListesi
        End Function
        
        Public Function CariHareketListesiAsync() As System.Threading.Tasks.Task(Of System.Data.DataTable) Implements DemoWebServiceReference.DemoWebServiceSoap.CariHareketListesiAsync
            Return MyBase.Channel.CariHareketListesiAsync
        End Function
    End Class
End Namespace
