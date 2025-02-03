using System;

[AttributeUsage(AttributeTargets.Method, Inherited = false)]
public class ThisMethodNeedsAttentionAttribute : Attribute
{
    public string Message { get; set; }

    public ThisMethodNeedsAttentionAttribute(string message)
    {
        Message = message;
    }
}