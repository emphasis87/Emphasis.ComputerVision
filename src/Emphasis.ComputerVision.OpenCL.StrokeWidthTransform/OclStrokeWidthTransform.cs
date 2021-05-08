using System;

namespace Emphasis.ComputerVision.OpenCL.StrokeWidthTransform
{
	public class OclStrokeWidthTransform
	{
		public static void StrokeWidthTransformExact(
			nint queueId,
			nint srcImageId,
			nint dstImageId,
			nint[] waitOnEvents,
			out nint onFinishedEvent,
			int rays = 1,
			int rayBend = 15,
			bool direction = true)
		{

		}
		
	}
}
