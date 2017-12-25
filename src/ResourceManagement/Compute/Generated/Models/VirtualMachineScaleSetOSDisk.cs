// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a virtual machine scale set operating system disk.
    /// </summary>
    public partial class VirtualMachineScaleSetOSDisk
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetOSDisk
        /// class.
        /// </summary>
        public VirtualMachineScaleSetOSDisk()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineScaleSetOSDisk
        /// class.
        /// </summary>
        /// <param name="createOption">Specifies how the virtual machines in
        /// the scale set should be created.&lt;br&gt;&lt;br&gt; The only
        /// allowed value is: **FromImage** \u2013 This value is used when you
        /// are using an image to create the virtual machine. If you are using
        /// a platform image, you also use the imageReference element described
        /// above. If you are using a marketplace image, you  also use the plan
        /// element previously described. Possible values include: 'FromImage',
        /// 'Empty', 'Attach'</param>
        /// <param name="name">The disk name.</param>
        /// <param name="caching">Specifies the caching requirements.
        /// &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt;
        /// **None** &lt;br&gt;&lt;br&gt; **ReadOnly** &lt;br&gt;&lt;br&gt;
        /// **ReadWrite** &lt;br&gt;&lt;br&gt; Default: **None for Standard
        /// storage. ReadOnly for Premium storage**. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'</param>
        /// <param name="osType">This property allows you to specify the type
        /// of the OS that is included in the disk if creating a VM from
        /// user-image or a specialized VHD. &lt;br&gt;&lt;br&gt; Possible
        /// values are: &lt;br&gt;&lt;br&gt; **Windows** &lt;br&gt;&lt;br&gt;
        /// **Linux**. Possible values include: 'Windows', 'Linux'</param>
        /// <param name="image">Specifies information about the unmanaged user
        /// image to base the scale set on.</param>
        /// <param name="vhdContainers">Specifies the container urls that are
        /// used to store operating system disks for the scale set.</param>
        /// <param name="managedDisk">The managed disk parameters.</param>
        public VirtualMachineScaleSetOSDisk(DiskCreateOptionTypes createOption, string name = default(string), CachingTypes? caching = default(CachingTypes?), OperatingSystemTypes? osType = default(OperatingSystemTypes?), VirtualHardDisk image = default(VirtualHardDisk), IList<string> vhdContainers = default(IList<string>), VirtualMachineScaleSetManagedDiskParameters managedDisk = default(VirtualMachineScaleSetManagedDiskParameters))
        {
            Name = name;
            Caching = caching;
            CreateOption = createOption;
            OsType = osType;
            Image = image;
            VhdContainers = vhdContainers;
            ManagedDisk = managedDisk;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the disk name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets specifies the caching requirements.
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values are:
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **None**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **ReadOnly**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **ReadWrite**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Default: **None for Standard
        /// storage. ReadOnly for Premium storage**. Possible values include:
        /// 'None', 'ReadOnly', 'ReadWrite'
        /// </summary>
        [JsonProperty(PropertyName = "caching")]
        public CachingTypes? Caching { get; set; }

        /// <summary>
        /// Gets or sets specifies how the virtual machines in the scale set
        /// should be created.&amp;lt;br&amp;gt;&amp;lt;br&amp;gt; The only
        /// allowed value is: **FromImage** \u2013 This value is used when you
        /// are using an image to create the virtual machine. If you are using
        /// a platform image, you also use the imageReference element described
        /// above. If you are using a marketplace image, you  also use the plan
        /// element previously described. Possible values include: 'FromImage',
        /// 'Empty', 'Attach'
        /// </summary>
        [JsonProperty(PropertyName = "createOption")]
        public DiskCreateOptionTypes CreateOption { get; set; }

        /// <summary>
        /// Gets or sets this property allows you to specify the type of the OS
        /// that is included in the disk if creating a VM from user-image or a
        /// specialized VHD. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible
        /// values are: &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Windows**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Linux**. Possible values
        /// include: 'Windows', 'Linux'
        /// </summary>
        [JsonProperty(PropertyName = "osType")]
        public OperatingSystemTypes? OsType { get; set; }

        /// <summary>
        /// Gets or sets specifies information about the unmanaged user image
        /// to base the scale set on.
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public VirtualHardDisk Image { get; set; }

        /// <summary>
        /// Gets or sets specifies the container urls that are used to store
        /// operating system disks for the scale set.
        /// </summary>
        [JsonProperty(PropertyName = "vhdContainers")]
        public IList<string> VhdContainers { get; set; }

        /// <summary>
        /// Gets or sets the managed disk parameters.
        /// </summary>
        [JsonProperty(PropertyName = "managedDisk")]
        public VirtualMachineScaleSetManagedDiskParameters ManagedDisk { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
