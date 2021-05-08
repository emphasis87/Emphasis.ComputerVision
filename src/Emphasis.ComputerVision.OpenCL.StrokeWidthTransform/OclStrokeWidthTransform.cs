using System;

namespace Emphasis.ComputerVision.OpenCL.StrokeWidthTransform
{
	public static partial class OclComputerVision
	{
		public static void StrokeWidthTransform(
			nint queueId,
			nint srcImageId,
			nint dstImageId,
			nint[] waitOnEvents,
			out nint onCompletedEvent,
			int rays = 1,
			int rayBend = 15,
			bool direction = true)
		{
			onCompletedEvent = default;
		}
		
	}
}
